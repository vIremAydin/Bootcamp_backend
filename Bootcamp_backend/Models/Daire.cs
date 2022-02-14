namespace Bootcamp_backend.Models;

public class Daire
{
    /*const [blockNo, setBlockNo] = useState(0);
    const [empty, setEmpty] = useState(true);
    const [type, setType] = useState("");
    const [floor, setFloor] = useState(0);
    const [no, setNo] = useState(0);
    const [owner, setOwner] = useState("");*/

    public int blockNo { get; set; }
    public int no { get; set; }
    public int floor { get; set; }
    public string owner { get; set; }
    public string type { get; set; }
}