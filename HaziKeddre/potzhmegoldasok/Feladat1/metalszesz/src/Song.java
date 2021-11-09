public class Song {
    private String title;
    private String artist;
    private int hossz;

    public Song(String title, String artist, int hossz) {
        this.title = title;
        this.artist = artist;
        this.hossz = hossz;
    }

    public String getTitle() {
        return title;
    }

    public String getArtist() {
        return artist;
    }

    public int getHossz() {
        return hossz;
    }


}
