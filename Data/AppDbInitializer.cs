using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using MovieHouse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieHouse.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();

                //Cinemas
                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<CinemaModel>()
                    {
                        new CinemaModel
                        {
                            Name = "Amazon Studios",
                            Logo = "https://www.logo.wine/a/logo/Amazon_Studios/Amazon_Studios-Logo.wine.svg",
                            Description = "Amazon Studios is an American television and film producer and distributor that is a subsidiary of Amazon. It specializes in developing television series and distributing and producing films. It was started in late 2010. Content is distributed through theaters and Amazon Prime Video, Amazon's digital video streaming service, whose competitors include Netflix and Hulu, among others."
                        },
                        new CinemaModel
                        {
                            Name = "Netflix",
                            Logo = "https://toppng.com/uploads/preview/netflix-logo-png-11593869496jqso5gxgsy.png",
                            Description = "Netflix, Inc. is an American subscription streaming service and production company. Launched on August 29, 1997, it offers a film and television series library through distribution deals as well as its own productions, known as Netflix Originals."
                        },
                        new CinemaModel
                        {
                            Name = "Hulu",
                            Logo = "https://yt3.ggpht.com/ytc/AKedOLQdF7_QX9SKsaLx3OCHq6lo3ajklRGeacSWvL77Dg=s900-c-k-c0x00ffffff-no-rj",
                            Description = "Hulu is an American subscription streaming service majority-owned by The Walt Disney Company, with Comcast’s NBCUniversal holding a minority stake."
                        },
                        new CinemaModel
                        {
                            Name = "Paramount Pictures",
                            Logo = "https://logos-world.net/wp-content/uploads/2022/02/Paramount-Pictures-Logo-700x394.png",
                            Description = "Paramount Pictures Corporation is an American film and television production and distribution company and the main namesake subsidiary of Paramount Global (formerly ViacomCBS). It is the fifth oldest film studio in the world."
                        },
                        new CinemaModel
                        {
                            Name = "Disney Studios",
                            Logo = "https://spng.pngfind.com/pngs/s/56-565324_disney-logo-png-transparent-disney-official-logo-png.png",
                            Description = "The Disney Studios is an American film and entertainment studio, and is the Studios Content segment of the Walt Disney Company"
                        }
                     });
                    context.SaveChanges();
                }
                //Actors
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<ActorModel>()
                    {
                        new ActorModel
                        {
                            FirstName = "Casey",
                            LastName = "Affleck",
                            ProfilePictureURL = "https://m.media-amazon.com/images/M/MV5BMTY3Nzc0MDg1OF5BMl5BanBnXkFtZTgwMzk5OTk2OTE@._V1_UY317_CR129,0,214,317_AL_.jpg",
                            Bio = "Caleb Casey McGuire Affleck-Boldt is an American actor and filmmaker. He is the recipient of various accolades, including an Academy Award, a British Academy Film Award, a Golden Globe Award and a Satellite Award."
                        },
                        new ActorModel
                        {
                            FirstName = "Leonardo",
                            LastName = "DeCaprio",
                            ProfilePictureURL = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR2q9tvih6sHPAEEbPoCRrWpf2IWVG5IOo5jIxqCA7dgrggsQO5",
                            Bio = "Leonardo Wilhelm DiCaprio is an American actor and film producer. Known for his work in biopics and period films, he is the recipient of numerous accolades, including an Academy Award, a British Academy Film Award, and three Golden Globe Awards."
                        },
                        new ActorModel
                        {
                            FirstName = "Adam",
                            LastName = "Sandler",
                            ProfilePictureURL = "https://encrypted-tbn1.gstatic.com/images?q=tbn:ANd9GcS9Y1dQuVczqcGeqn4zUOxTSDGHGulhjS-WWreliyiWs7B9YDyA",
                            Bio = "Adam Richard Sandler is an American comedian, actor, and filmmaker. He was a cast member on Saturday Night Live from 1990 to 1995, before going on to star in many Hollywood films, which have combined to earn more than $4 billion at the box office. "
                        },
                        new ActorModel
                        {
                            FirstName = "Drew",
                            LastName = "Barrymore",
                            ProfilePictureURL = "https://www.pinkvilla.com/files/styles/amp_metadata_content_image/public/drew_barrymore_dating.jpg",
                            Bio = "Drew Blythe Barrymore is an American actress, producer, talk show host and author."
                        },
                        new ActorModel
                        {
                            FirstName = "Johnny",
                            LastName = "Depp",
                            ProfilePictureURL = "https://media.gettyimages.com/photos/actor-johnny-depp-poses-for-a-portrait-in-1988-in-new-york-city-new-picture-id686020130?k=20&m=686020130&s=612x612&w=0&h=_krgzgehUzcWCh7_fcGvg7AwH7n-b761S49_lczVxoU=",
                            Bio = "John Christopher Depp II is an American actor, producer and musician. He is the recipient of multiple accolades, including a Golden Globe Award and a Screen Actors Guild Award, in addition to nominations for three Academy Awards and two BAFTAs."
                        }
                     });
                    context.SaveChanges();
                }
                //Directors
                if (!context.Directors.Any())
                {
                    context.Directors.AddRange(new List<DirectorModel>()
                    {
                        new DirectorModel
                        {
                            FirstName = "Wayne Roberts",
                            LastName = "Roberts",
                            ProfilePictureURL = "https://encrypted-tbn0.gstatic.com/licensed-image?q=tbn:ANd9GcT0mCFupTW90LijxObE-gkAj7gMxV2FB5WxVDpuDMoWq5cSJV4Sldx-gzvw&s=19",
                            Bio = "Wayne Roberts is a director and writer, known for Katie Says Goodbye (2016) and The Professor (2018)."
                        },
                        new DirectorModel
                        {
                            FirstName = "Terrence",
                            LastName = "Malick",
                            ProfilePictureURL = "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcQShGgGm_E5Tff6aW8G0kkKTJrbu8sY8kEbDLKILy4-tp-ZHdV9",
                            Bio = "Terrence Frederick Malick is an American film director, screenwriter, and producer."
                        }
                     });
                    context.SaveChanges();
                }
                //Producers
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<ProducerModel>()
                    {
                        new ProducerModel
                        {
                            FirstName = "Brad",
                            LastName = "Pitt",
                            ProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/4c/Brad_Pitt_2019_by_Glenn_Francis.jpg/330px-Brad_Pitt_2019_by_Glenn_Francis.jpg",
                            Bio = "William Bradley Pitt (born December 18, 1963) is an American actor and film producer. He is the recipient of various accolades, including an Academy Award, a British Academy Film Award, and two Golden Globe Awards for his acting, in addition to a second Academy Award, a second British Academy Film Award, a third Golden Globe Award, and a Primetime Emmy Award as a producer under his production company, Plan B Entertainment."
                        },
                        new ProducerModel
                        {
                            FirstName = "Brian",
                            LastName = "Jones",
                            ProfilePictureURL = "https://m.media-amazon.com/images/M/MV5BZTAzNTEzNmMtZTg3ZS00MzgwLThiMDYtMWYyYjUzNTE1ZDQ4XkEyXkFqcGdeQXVyNTM5NjgwMDM@._V1_UX214_CR0,0,214,317_AL_.jpg",
                            Bio = "Brian Kavanaugh-Jones is a producer and actor, known for Midnight Special (2016), Upgrade (2018) and Sinister (2012."
                        }
                    });
                    context.SaveChanges();
                }
                //Movies
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<MovieModel>()
                    {
                        new MovieModel
                        {
                            Name = "Manchester By The Sea",
                            Description = "After his brother's death, Lee Chandler is named guardian to his 16-year-old nephew, Patrick. This forces him to return to his hometown and confront his past.",
                            Rating = 7.8,
                            ImageURL = "https://dynamic.indigoimages.ca/v1/books/books/1468316613/1.jpg?quality=10&width=320&maxheight=320",
                            Genre = Genre.Tragedy,
                            DirectorId = 1,
                            ProducerId = 2,
                            CinemaId = 5
                        },
                        new MovieModel
                        {
                            Name = "Fifty First Dates",
                            Description = "Henry, a vet, falls in love with Lucy, who suffers from short-term memory loss. Lucy can never remember meeting him, so Henry has to romance her afresh each day and pray that she too loves him.",
                            Rating = 6.8,
                            ImageURL = "https://upload.wikimedia.org/wikipedia/en/9/9d/50FirstDates.jpg",
                            Genre = Genre.Romance,
                            DirectorId = 2,
                            ProducerId = 1,
                            CinemaId = 4
                        },
                        new MovieModel
                        {
                            Name = "The Departed",
                            Description = "An undercover agent and a spy constantly try to counter-attack each other in order to save themselves from being exposed in front of the authorities. Meanwhile, both try to infiltrate an Irish gang.",
                            Rating = 8.5,
                            ImageURL = "https://images-eu.ssl-images-amazon.com/images/S/pv-target-images/185e67e0caace3f1bc7021328379cd8a66b09bf178607467b92695ee0aed2f19._V_SX450_.jpg",
                            Genre = Genre.Thriller,
                            DirectorId = 1,
                            ProducerId = 2,
                            CinemaId = 3
                        },
                        new MovieModel
                        {
                            Name = "The Professor",
                            Description = "Richard Brown, an English professor, is diagnosed with an advanced stage of cancer but he decides to not let the illness get the best of him and lives his life to the fullest.",
                            Rating = 6.7,
                            ImageURL = "https://assets-in.bmscdn.com/iedb/movies/images/extra/vertical_logo/mobile/thumbnail/xxlarge/the-professor-et00301242-22-01-2021-06-23-56.jpg",
                            Genre = Genre.Tragicomedy,
                            DirectorId = 2,
                            ProducerId = 1,
                            CinemaId = 1
                        },
                        new MovieModel
                        {
                            Name = "Into The Wild",
                            Description = "Christopher McCandless, a young graduate, decides to renounce all his possessions and hitchhike across America. During his journey, he encounters several situations which change him as a person.",
                            Rating = 8.1,
                            ImageURL = "https://www.thenewleam.com/wp-content/uploads/2017/09/into-the-wild-670x448.jpg",
                            Genre = Genre.Adventure,
                            DirectorId = 1,
                            ProducerId = 2,
                            CinemaId = 4
                        },
                     });
                    context.SaveChanges();
                }
                //ActorMovies
                if (!context.ActorMovies.Any())
                {
                    context.ActorMovies.AddRange(new List<ActorMovieModel>()
                    {
                        new ActorMovieModel
                        {
                            MovieId = 2,
                            ActorId = 4
                        },
                        new ActorMovieModel
                        {
                            MovieId = 1,
                            ActorId = 1
                        },
                        new ActorMovieModel
                        {
                            MovieId = 3,
                            ActorId = 2
                        },
                        new ActorMovieModel
                        {
                            MovieId = 2,
                            ActorId = 3
                        },
                        new ActorMovieModel
                        {
                            MovieId = 4,
                            ActorId = 5
                        },
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
