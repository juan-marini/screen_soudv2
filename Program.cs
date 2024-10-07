Banda queen = new Banda("Queen");

Album albumDoQueen = new Album("A night at the opera");

Musica musica1 = new Musica(queen, "Love of my life")
{
    Duracao = 213,
    Disponivel = true,
};

Musica musica2 = new Musica(queen, "Bohemian Rhapsody")
{
    Duracao = 354,
    Disponivel = false,
};

albumDoQueen.AdicionarMusica(musica1);
albumDoQueen.AdicionarMusica(musica2);
queen.AdicionarAlbum(albumDoQueen);

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
albumDoQueen.ExibirMusicasDoAlbum();
queen.ExibirDiscografia();

Episodio ep1 = new(4, "Técnicas de Facilitação", 45);
ep1.AdicionarConvidados("Ana Pereira");
ep1.AdicionarConvidados("Mário Francis");

Episodio ep2 = new(2, "Aprendendo a aprender", 78);
ep2.AdicionarConvidados("Marcos Felício");

Episodio ep3 = new(3, "Consciênciologia", 87);
ep3.AdicionarConvidados("Flavio Almeida");
ep3.AdicionarConvidados("Gui Lima");
ep3.AdicionarConvidados("Fernanda Fernandes");

Episodio ep0 = new(1, "Filosofia de software", 93);
ep0.AdicionarConvidados("Fernando Roberto");
ep0.AdicionarConvidados("Gabriel Barbosa");

Podcast podcast = new("TI para Poucos", "Daniel Portugal");
podcast.AdicionarEpisodio(ep1);
podcast.AdicionarEpisodio(ep2);
podcast.AdicionarEpisodio(ep3);
podcast.AdicionarEpisodio(ep0);

podcast.ExibirDetalhes();


