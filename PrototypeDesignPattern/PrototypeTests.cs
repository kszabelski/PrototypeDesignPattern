using NUnit.Framework;

namespace PrototypeDesignPattern
{
    public class PrototypeTests
    {
        [Test]
        public void ShouldCloneMovieOnEachCallToFactory()
        {
            var movie = PrototypeFactory.GetInstance<Movie>();
            var yetAnotherMovie = PrototypeFactory.GetInstance<Movie>();
            
            Assert.IsFalse(movie == yetAnotherMovie);
        }

        [Test]
        public void ShouldCloneAlbumOnEachCallToFactory()
        {
            var album = PrototypeFactory.GetInstance<Album>();
            var yetAnotherAlbum = PrototypeFactory.GetInstance<Album>();

            Assert.IsFalse(album == yetAnotherAlbum);
        }

        [Test]
        public void ShouldCloneMovie()
        {
            var movie = PrototypeFactory.GetInstance<Movie>();
            
            Assert.AreEqual("Batman forever", movie.Title);
        }

        [Test]
        public void ShouldCloneAlbum()
        {
            var album = PrototypeFactory.GetInstance<Album>();
            
            Assert.AreEqual("Robocop songs", album.Name);
        }
    }
}
