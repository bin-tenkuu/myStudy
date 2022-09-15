apt install -y ffmpeg ipset iptables screen nginx-extras lsof git g++ gcc bash-completion net-tools
curl -s https://install.zerotier.com | sudo bash
cd /home || exit
ln -s /etc/nginx/ nginx
mkdir "asf" "banip" "frp" "mirai"

