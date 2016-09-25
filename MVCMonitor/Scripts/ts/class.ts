class Host {
    public HostName: string;
    public HostIPAddress: string;

    public GetHostName():string {
        return this.HostName;
    }

    public GetIPAddress():string {
        return this.HostIPAddress;
    }
}