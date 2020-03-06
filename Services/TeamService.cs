//using Repository;

//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Services
//{
  
//        public class TeamService
//        {
//            public class BasketService
//            {
//                private IList<IPlayerProcessor> _basketProcessors;
//                private readonly IPlayerProcessorFactory _basketProcessorFactory;

//                public BasketService(IPlayerProcessorFactory basketProcessorFactory)
//                {
//                    _basketProcessorFactory = basketProcessorFactory;
//                }

//                public PlayerServiceResponse GetBasketTotal(IShoppingBasket shoppingBasket)
//                {
//                    try
//                    {
//                        if (!shoppingBasket.GetBasketItems().Any())
//                            return new PlayerServiceResponse()
//                            {
//                                Notifications = new List<string> { "Your shopping basket is empty" },
//                                Success = true,
//                                BasketTotal = 0.0m
//                            };

//                        _basketProcessors = CreateBasketProcessors();

//                        foreach (var processor in _basketProcessors)
//                        {
//                            processor.Process(shoppingBasket);
//                        }

//                        return new PlayerServiceResponse
//                        {
//                            Notifications = shoppingBasket.Messages?.ToList(),
//                            BasketTotal = shoppingBasket.Total,
//                            Success = true
//                        };


//                    }
//                    catch (Exception exception)
//                    {
//                        return new PlayerServiceResponse
//                        {
//                            ErrorMessage = $"Failed to calculate basket total {exception.Message}",
//                            Success = false,
//                            BasketTotal = 0.0m
//                        };
//                    }

//                }

//                private IList<IPlayerProcessor> CreatePLayerProcessors()
//                {
//                return new List<IPlayerProcessor>
//                {
//                };
//                }
//            }
//        }
//    }

//}
