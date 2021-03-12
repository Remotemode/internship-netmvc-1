﻿using Sharetrade.Models;
using System.Collections.Generic;

namespace Sharetrade.Mocks
{ 
    public class ArticleMocks
    {
        public List<KeyValuePair<string, Article>> GetArticleMocks()
        {
            var articles = new List<KeyValuePair<string, Article>>();
            articles.Add(new KeyValuePair<string, Article>("Key1", GetArticleMockOne()));
            articles.Add(new KeyValuePair<string, Article>("Key2", GetArticleMockTwo()));
            articles.Add(new KeyValuePair<string, Article>("Key3", GetArticleMockThree()));
            articles.Add(new KeyValuePair<string, Article>("Key4", GetArticleMockFour()));
            articles.Add(new KeyValuePair<string, Article>("Key5", GetArticleMockFive()));
            articles.Add(new KeyValuePair<string, Article>("Key6", GetArticleMockSix()));
            articles.Add(new KeyValuePair<string, Article>("Key7", GetArticleMockSeven()));
            articles.Add(new KeyValuePair<string, Article>("Key8", GetArticleMockEight()));
            articles.Add(new KeyValuePair<string, Article>("Key9", GetArticleMockNine()));
            articles.Add(new KeyValuePair<string, Article>("Key10", GetArticleMockTen()));

            return articles;
        }

        public List<Article> GetArticles()
        {
            return new List<Article>
            {
                GetArticleMockOne(),
                GetArticleMockTwo(),
                GetArticleMockThree(),
                GetArticleMockFour(),
                GetArticleMockFive(),
                GetArticleMockSix(),
                GetArticleMockSeven(),
                GetArticleMockEight(),
                GetArticleMockNine(),
                GetArticleMockTen()
            };
        }

        public Article GetArticleMockOne()
        {
            return new Article
            {
                Title =
                    "The New York Stock Exchange president says the stock market is not a casino. Here’s what academic research says.",
                Description =
                    "Some economically-sensitive stocks have underperformed the broader market, while the U.S. dollar has risen. " +
                    "That combination makes some nervous about those stocks, but they needn’t worry.\r\n\r\nIndustrials and banks, " +
                    "two highly cyclical sectors, are marginally underperforming the border market since January 6, " +
                    "the date that marked a reversal of the Dollar’s downtrend. The Industrial Select Sector SPDR Fund (XLI) has " +
                    "underperformed the S&P 500 by almost 4 percentage points since January 6, while the SPDR S&P Bank ETF (KBE) has " +
                    "underperformed by less than a tenth of a percentage point. Since that date, the U.S. Dollar Index (DXY) is up 1.6%.\r\n\r\nUsually, " +
                    "when the dollar rises, equities in general perform poorly because global investors are moving into safe haven assets as they see the " +
                    "global economic outlook weakening. “If USD were to show a notable strengthening this year, that would, to some extent, " +
                    "go against our bullish equity market call,” wrote JPMorgan global equity strategists in a note. That certainly doesn’t " +
                    "set up well for cyclical stocks.\r\n\r\nBut this moment is different; the dollar’s strength isn’t a refection of global risk " +
                    "aversion from investors, but rather a U.S. economy expected to perform handsomely relative to other countries for the longer-term, " +
                    "even as all economies rebound from the pandemic. Also, U.S. interest rates are expected to rise faster than in other countries over " +
                    "the next several years, making owning the greenback more attractive versus other currencies. That’s also consistent with " +
                    "the theme of U.S. economic growth outperformance.\r\n\r\nThis all lends itself to strong performance for cyclical stocks. " +
                    "“Weakness in cyclicals due to Dollar gains represent buying opportunities assuming USD strength is based on improving growth prospects,” " +
                    "wrote Dennis DeBusschere, head of portfolio strategy research at Evercore in a note. “Don’t dump cyclicals because the dollar is strengthening,” " +
                    "Yung Yu Ma, chief investment strategist at BMO Wealth Management told Barron’s. “Industrials and financials will do well.”\r\n\r\nGiven the positions of" +
                    " DeBusschere and Ma, some might be scratching their heads at why those cyclicals aren’t top performers this year. Actually, they have been spectacular " +
                    "outperformers since September 23, the start of a fresh rally in stocks and a move into assets that benefit with a strengthening economy. " +
                    "The Industrial Select Sector SPDR Fund is up 19%, roughly in line with the S&P 500’s gain. The SPDR S&P Bank ETF is up 65%. Notably, " +
                    "energy stocks, as seen by the Energy Select Sector SPDR Fund (XLE), is up 46% since that date. Ma says cyclical stocks are taking a breather, " +
                    "while other forgotten areas of the market catch up.\r\n\r\nBelieving in the global economy’s upturn means believing in cyclicals — regardless of what the dollar does.",
                ImageUrl = "https://images.mktw.net/im-299272",
                ExpertComment =
                    "Over long periods of time the market reflects the gradual growth of the larger economy.\nBut many people want to  be rich now, or beat the average. " +
                    "This is gambling. It is based on a few stocks for a short period of time, and assumes all the other traders are rational in some way. " +
                    "\nIn the short term the market acts like a herd of cows: always looking to stampede in some direction. In the long run the cows always return " +
                    "to the barn.\nSo, be aware that gambling and a sure bet operate at different time scales. I have no interest in learning enough about any stock, " +
                    "to make day trades. \nAnd investing for the long term has more than doubled my money."
            };
        }

        public Article GetArticleMockTwo()
        {
            return new Article
            {
                Title = "Bitcoin $50,000 milestone nears as world’s No. 1 cryptocurrency rises in 2021",
                Description =
                    "Bitcoin prices on Sunday were approaching a psychological milestone around $50,000.\n\nThe weekend move pushed the world’s No. " +
                    "1 digital asset to a fresh record mark of $49,716.44, according to CoinDesk, adding to a steady grind toward all-time highs as greater " +
                    "attention and more institutional investments in cryptos has provided a felicitous near-term backdrop for the virtual market" +
                    ".\n\nBitcoin boom\nAfter a lull early in 2020, the crypto has rocketed higher in recent weeks as corporations have signed on.\n\nBitcoin’s BTCUSD, " +
                    "1.64% momentum higher has driven it to a year-to-date gain of over 64%, compared with a rise of 2.8% for the Dow Jones Industrial Average DJIA, +0.09%, " +
                    "a 4.8% advance for the S&P 500 index SPX, +0.47% and fetching 9.4% rally for the Nasdaq Composite Index COMP, +0.50% thus far in 2021.\r\n\r\nAlthough, " +
                    "there is no specific news helping to extend gains for bitcoins, the rally comes as the asset appears to be gathering steam and increased " +
                    "attention among the traditional investment community.\r\n\r\nOver the weekend, Bloomberg News, citing people familiar, reported that a Morgan Stanley MS, " +
                    "+1.21% investment management unit, Counterpoint Global, was exploring buying cryptos for its investors.\r\n\r\nThat report comes after " +
                    "The Wall Street Journal earlier last week said that Bank of New York Mellon, BK would hold, transfer and issue bitcoin and other cryptocurrencies on behalf of its clients." +
                    "\r\n\r\n“Digital assets are becoming part of the mainstream,” Roman Regelman, chief executive of BNY Mellon’s asset-servicing and digital businesses, was quoted as telling WSJ." +
                    "\r\n\r\nOn top of that, last Wednesday, Mastercard MA, -0.55%  said it would support certain cryptocurrencies on its network later this year and Tesla Inc. TSLA," +
                    " +0.55% said it purchased $1.5 billion of bitcoin and would eventually allow customers to use the cryptocurrency to purchase its products.",
                ImageUrl = "https://images.mktw.net/im-299199",
                ExpertComment =
                    "Interesting how Etheruem value is in lockstep with all bitcoin moves; and if one has ethereum, one has to convert ethereum to bitcoin, to take in any gains. " +
                    "This has to stop and be regulated because ethereum is so linked, it cannot move on it's own merit. So it's just an investment facet of btc?  And you can't trade, " +
                    "spend ethereum without 1st converting to bitcoin- if btc is a valid tool of commerce, ethereum should also, thus would cause  its bubble to burst if not linked; " +
                    "or maybe it would skyrocket if not being linked? World is not ready, only in increments."
            };
        }

        public Article GetArticleMockThree()
        {
            return new Article
            {
                Title = "The Stock Market Keeps Rising. The Reasons to Be Hopeful Are Also the Reasons to Worry.",
                Description =
                    "Yes, you can have too much of a good thing—and the stock market is starting to consider what that might mean for future gains." +
                    "\r\n\r\nYou wouldn’t be able to tell just from looking at the market last week. The Dow Jones Industrial Average, after all, " +
                    "rose 310.16 points, or 1%, to 31,458.40, while the S&P 500 advanced 1.2%, to 3934.83, and the Nasdaq Composite gained 1.7%. " +
                    "All three closed at record highs. What could be wrong with that?\r\n\r\nNot much, apparently. The chance that a huge relief bill " +
                    "gets passed has risen so high that the market assumes it’s a done deal. Disappointing economic data, like weaker-than-expected jobless claims, " +
                    "continue to be dismissed. And optimism about our ability to vaccinate the U.S. population and end the pandemic appears to be rising." +
                    "\r\n\r\n\r\nBut there is a sense of unease percolating, a sense that something is not quite right with markets. " +
                    "You can see it in the continued influence of retail trading, which found a new-old target in pot stocks, " +
                    "helping to drive shares of the ETFMG Alternative Harvest exchange-traded fund (ticker: MJ) up 42% through Wednesday and then down 26% through Friday’s close. " +
                    "It’s in the small-cap Russell 2000, which gained 2.5% on the week, to 2289.36, and has now outperformed the S&P 500 by 11 percentage points in 2021. " +
                    "And it’s there in the 10-year Treasury yield, which closed the week at 1.199%, its highest since March 2020. Do these things make sense? " +
                    "And if so, what do they mean for the overall market?\r\n\r\n\r\nPart of the problem is simply the known unknowns. For instance, " +
                    "no one is quite sure when the economy will reopen and what it will look like. We can assume there’s pent-up demand, that workers in restaurants, retail, " +
                    "and other service-oriented business will have jobs to go back to, and people will want to fly to vacation destinations once again, " +
                    "but we won’t know for sure until it happens. “My base case is that it works out well,” says Drew Matus, chief market strategist at MetLife Investment Management. " +
                    "“It all boils down to the speed people feel comfortable re-engaging.”\r\n\r\n\r\nThere’s also starting to be some concern that maybe, just maybe," +
                    " there may be too much stimulus coming down the pike. Details of a possible $1.9 trillion package are still being worked out," +
                    " but President Joe Biden has already held a meeting with senators to discuss an infrastructure plan, which could add an additional trillion or more." +
                    " That has created concerns over higher taxes to pay for the plan, as well as even higher yields, to reflect the possibility of stronger growth—and what " +
                    "they would mean for a market that’s already showing signs of froth.\r\n\r\n\r\n“The biggest concern for stocks was higher taxes/regulation followed " +
                    "by inflation/higher rates, though the duration and severity of the pandemic remained a significant focus,” Evercore ISI’s Oscar Sloterbeck " +
                    "wrote about the firm’s survey of investors.\r\n\r\n\r\nFor now, though, the steady gains in bond yields have been good for the market, " +
                    "according to Ned Davis Research strategist Tim Hayes. He notes that the correlation between the yield " +
                    "on the Barclays Global Aggregate Bond index and global stocks currently sits at 0.24—a correlation of 1 means two assets move in lockstep—and has been " +
                    "fairly steady since the market stabilized after the coronavirus meltdown. If the correlation turns negative, which would mean that stocks and bonds " +
                    "move in opposite directions, it could be bad news for equities.\r\n\r\n“If the correlation would return to inversion, it would tell us that the markets " +
                    "had started to view rising yields as a threat to economic growth, and in turn corporate profits,” Hayes writes.\r\n\r\nFor now, though, we’ll continue " +
                    "to enjoy the gifts that keep on giving.",
                ImageUrl = "https://images.barrons.com/im-298906",
                ExpertComment =
                    "I think that sometime in the near future the tax crosshairs will be on the 1% because the promises that were made with Trump's tax cut didn't pan out prior to the pandemic. " +
                    "Baby boomers are starting to tap into Social Security and it's only going to get worse by the time it's my turn at the feeding trough. " +
                    "Someone is going to have to pick up the tab and hitting the middle class is the proverbial third rail. The gains the market is experiencing is happening in a " +
                    "very compressed timeline because today's highs shouldn't have happened for at least four years down the road. Look at the S&P trend over the 10 years prior to " +
                    "2020 and compare it to the last 12 months. Something is weird about the market and I predict a major correction this year.\n\n"
            };
        }

        public Article GetArticleMockFour()
        {
            return new Article
            {
                Title = "Stocks Close at New Records as Investors Bet on Vaccines",
                Description =
                    "Stocks closed at new highs Friday, as investors assessed corporate earnings and upbeat comments about the U.S.’s Covid-19 vaccine rollout." +
                    "\n\nThe Dow Jones Industrial Average advanced 27.70 points, or 0.1%, to 31,458.40. The S&P 500 gained 18.45 points, or 0.5%, to 3,934.83, " +
                    "and the Nasdaq Composite advanced 69.70 points, or 0.5%, to 14,095.47. All three major benchmarks closed at new highs, while the small-cap Russell 2000 closed 0.1% higher. " +
                    "For the week, the Dow industrials rose 1%, the S&P 500 gained 1.2% and the Nasdaq climbed 1.7%.\n\nMost Asian markets were closed for the Lunar New Year holiday, " +
                    "but the Nikkei 225 index and Australia’s S&P/ASX 200 both finished lower. The Stoxx Europe 600 index advanced 0.6%, while the German DAX gained 0.1%. Brent oil and U.S. " +
                    "crude prices each climbed about 2.1%.\n\nThe news on the vaccine front has been mixed, as a new Covid-19 variant that originated in South Africa has spread to the U.S. " +
                    "West Coast. At the same time, though, President Joe Biden’s administration has arranged to purchase hundreds of millions more vaccine doses and will have enough to " +
                    "vaccinate 300 million Americans—the majority of the country—by the end of July.\n\nThe concern for investors is that some vaccines may not adequately " +
                    "immunize against the new variants. That leaves in question the pace of reopenings and the outlook for the economic recovery." +
                    "\n\n“The last thing that anyone wants to see is the increase in the new variant cases in the U.S., which could further adversely influence economic activity. " +
                    "If such an event ever occurs, it is very likely to trigger a sharp selloff for the S&P 500, and gold prices will move higher,” said Naeem Aslam, " +
                    "chief market analyst, to clients in a note.\n\nStronger-than-expected corporate earnings have also been driving stocks higher. " +
                    "Of the nearly three-quarters of companies in the S&P 500 that have reported fourth-quarter results, more than 80% have beat forecasts for profits, " +
                    "according to FactSet. If the trend continues, that would be the third-highest proportion since the data provider started tracking those statistics in 2008. " +
                    "The S&P 500 is also on track for its first year-over-year quarterly earnings growth since the end of 2019.\r\n\r\nAmong stocks on the move, " +
                    "shares of Bumble (ticker: BMBL) were up 7.3% after the dating-app operator climbed 64% in its Thursday debut. Alongside Bumble, Signify Health, Apria Healthcare, " +
                    "loanDepot and medical-device company Bioventus also had their initial public offerings on Thursday.\r\n\r\nExpedia (EXPE) shares fell 2.3% after the online " +
                    "travel service posted a wider-than-expected net loss. The company said it lost $2.64 per share, against estimates of $1.92. Expedia posted revenue of $920 million, " +
                    "below the forecast of $1.1 billion.\r\n\r\nWalt Disney stock (DIS) fell 1.7% even after the company smashed earnings-per-share estimates, posting a result of 32 cents, " +
                    "against estimates of a 41-cent loss. The company said revenue was $16.25 billion, which beat expectations of $15.9 billion." +
                    "\r\n\r\nRestaurant Brands International (QSR) slipped 0.2% after Baird downgraded the stock to Neutral from Outperform." +
                    "\r\n\r\nNorwegian Cruise Line (NCLH) fell 1%. Berenberg lowered its rating on the stock to Hold from Buy.",
                ImageUrl = "https://images.barrons.com/im-298503",
                ExpertComment =
                    "Oil is making a nice come back today.  Looks like WTI of $60/bl is on the trading block to potentially come down possibly today but definitely in the very near future.  " +
                    "What are the catalyst buoying higher oil prices?\n\n1) EO making it harder for domestic oil to explore & drill on federal lands\n2) " +
                    "Anticipation of more regs on domestic oil \n3) Anticipated higher demand coming with the reopening of the US & world economies in 2021\n4) " +
                    "Falling domestic oil production\n5) OPEC+ staying disciplined in manage increases in oil supplies\n6) Oil companies cut in Cap/Ex spending for exploring & drilling " +
                    "for new oil reserves in the coming years\n7) Oil companies shifting resources to renewable green energy to offset their carbon foot print\n\nWhat does this all add up?" +
                    " Lower domestic supplies, OPEC+ has the ability to set prices again, & investors that picked up oil stocks during big oil wealth destruction phase are being & will be " +
                    "rewarded in 2021 & probably the next 3+ years. Follow the data points."
            };
        }

        public Article GetArticleMockFive()
        {
            return new Article
            {
                Title = "A Top Pension Bought More GE, Zoom, and Pfizer Stock. Here’s What It Sold.",
                Description =
                    "The manager of one of the best-run pensions in America, from a funding standpoint, made big changes in its investment portfolio." +
                    "\n\nThe State of Wisconsin Investment Board substantially increased positions in General Electric (ticker: GE), Zoom Video Communications (ZM), and Pfizer (PFE) stock, " +
                    "and cut about a quarter of its investment in Intel (INTC). The SWIB disclosed the stock trades, among others, in a form it filed with the Securities and Exchange Commission." +
                    "\n\nThe agency didn’t respond to a request for comment. About 91% of assets the investment board manages are the trust funds of the Wisconsin Retirement System, " +
                    "which totaled $129.8 billion at the end of 2020.\n\nThe Wisconsin Retirement System is one among a handful of state pensions that are fully funded. " +
                    "A study by the Pew Charitable Trusts that looked at 2018 data showed that the average state pension had a funded ratio of only 70.7%, which means only about 71 cents on " +
                    "hand for each dollar of obligations.\n\nThe SWIB bought 2.7 million more GE shares in the fourth quarter to end the year with 8.5 million shares of the conglomerate." +
                    "\n\nGE stock slipped 3.2% in 2020, but it has wiped out that loss by rising 8.6% so far this year. In comparison, the S&P 500 index, a measure of the broader market, " +
                    "rose 16.3% in 2020, but has gained 4.8% so far in 2021.\r\n\r\nSome GE bears eased off late last year, while other analysts remain skeptical. GE’s " +
                    "fourth-quarter report was notable for showing free-cash-flow growth and including upbeat financial forecasts.\r\n\r\nSWIB bought 386,625 additional shares of Zoom, " +
                    "raising its investment to 478,625 shares of the videoconferencing company. Zoom stock soared five-fold in value in 2020. So far in 2021, it has gained 28.4%." +
                    "\r\n\r\nDespite the impressive gains, Zoom stock has slipped from its highs, but it does have some support. One analyst recently called for the stock to top $600.\r\n\r\nPfizer stock slipped 1% in 2020, and so far in 2021, it has slid 5.7%.\r\n\r\nPfizer’s Covid-19 vaccine will work against new variants, the company’s research suggests. Earlier this month, Pfizer raised its estimate of sales for its vaccine after stumbles by rivals. The company recently reported mixed earnings.\r\n\r\nSWIB bought 924,796 additional Pfizer shares to end 2020 with 6.0 million shares.\r\n\r\nThe manager sold 676,844 Intel shares, cutting its investment in the chipmaker to 2.2 million shares. Intel stock slid 16.8% in 2020, but it is up 24.1% so far this year.\r\n\r\nIntel unnerved investors by disclosing manufacturing issues last July. Intel stock rallied early on in 2021 when the company revealed that CEO Bob Swan would be leaving. Swan bought shares in his last weeks with Intel.\r\n\r\n",
                ImageUrl = "https://images.barrons.com/im-298585",
                ExpertComment =
                    "Inside Scoop is a regular Barron’s feature covering stock transactions by corporate executives and board members—so-called insiders—as well as large shareholders, " +
                    "politicians, and other prominent figures. Due to their insider status, these investors are required to disclose stock trades with the Securities and Exchange " +
                    "Commission or other regulatory groups."

            };
        }

        public Article GetArticleMockSix()
        {
            return new Article
            {
                Title = "Apple’s Search for an Autonomous Vehicle Partner Continues. Who It Could Choose",
                Description = "Apple’s search for an auto maker to join the tech giant’s project to build autonomous vehicles continues, following reports that discussions have dissolved with Nissan." +
                                  "\n\nShares in the Japanese auto giant tumbled near 3% in Tokyo trading. Apple shares were not traded in the U.S. on Monday due to the Presidents Day holiday.\n\nThe back story. " +
                                  "There has been speculation over Apple’s vehicle ambitions since 2015, when The Wall Street Journal reported that it was gearing up to take on Tesla. " +
                                  "The iPhone maker has been highly secretive about its plans for “Project Titan,” confirmed in 2016, which has evolved to encompass self-driving, or autonomous, " +
                                  "electric vehicles.\n\nAnalysts have suspected that the Silicon Valley giant would partner with an existing auto maker to break into the capital-intensive vehicle industry." +
                                  "\n\nOn Feb. 8, Korean auto makers Hyundai and Kia said they were no longer in talks with Apple over an autonomous electric-vehicle project, " +
                                  "following widespread press and analyst speculation that a deal was near. That news had sent Hyundai stock down more than 6% and shares in Kia down 15%—eliminating a combined " +
                                  "$8.5 billion in market value from the two companies.\n\nThe next day, Nissan’s chief executive Makoto Uchida was pressed in an earrings call on whether the company had been " +
                                  "approached by Apple about a collaboration. Uchida avoided addressing Apple directly, but indicated that Nissan could partner with technology companies on building the next " +
                                  "generation of cars.\n\nWhat’s new. Nissan confirmed on Monday that it was not in talks with Apple, but said it was open to exploring collaborations and partnerships to accelerate " +
                                  "the vehicle industry.\n\nThe Financial Times had reported earlier that there were discussions between the two groups over a partnership, but that talks had stalled over possible branding. " +
                                  "According to the report, the discussions did not reach senior management levels.\n\nA source close to Nissan told Agence France-Presse that “when you make a product under " +
                                  "the Apple brand, you give your soul— and your profit margins— to Apple,” and that Nissan was “not interested in giving Apple the best that we offer.”\n\nLooking ahead. " +
                                  "It makes sense that Apple would partner with a strong auto maker to realize its electric-vehicle dreams. With Nissan crossed off, following Hyundai and Kia, that list is narrowing." +
                                  "\r\n\r\nOn Feb. 7, just before Hyundai and Kia confirmed they were not involved with Apple, veteran technology analyst Daniel Ives of investment firm Wedbush, " +
                                  "said it was a matter of “when not if” Apple entered the electric-vehicle race. Ives put the chances at 85% that the tech giant would announce a relevant partnership or " +
                                  "collaboration within the next three to six months.\r\n\r\nIves singled out Hyundai as the most likely choice, with Volkswagen Group —which also makes Audi and Porsche —as " +
                                  "the next best bet. With Hyundai out, investors should keep an eye on the German giant. The analyst also floated Tesla and Ford as possible candidates.",
                ImageUrl = "https://s.wsj.net/public/resources/images/ON-EH827_applec_M_20210215083117.jpg",
                ExpertComment = "Apple should just buy GM.  It will give them the fastest entry into the market, with a couple of dozen new EV's slated over the next few years " +
                                    "(including the beautiful Lyriq and Hummer), and with one of the best automation technologies in its' Cruise division.  GM is still very reasonably priced.  " +
                                    "Oh, and to top it all off, GM has the best CEO in the industry."
            };
        }

        public Article GetArticleMockSeven()
        {
            return new Article
            {
                Title = "Simon Property Group Tries to Turn the Corner on an Ugly Year for Malls",
                Description = "Shopping malls are the ultimate reopening trade, a bet on the resilience of the American consumer after nearly a solid year of stay-at-home orders and retail shutdowns." +
                                  "\r\n\r\nHow quickly shoppers will return to crowded public spaces is an issue that has plagued retailers and mall operators since the beginning of the pandemic last year, " +
                                  "when businesses were forced to shut to prevent the spread of Covid-19, sending shoppers online.\r\n\r\nShares of Simon Property Group (ticker: SPG), the biggest U.S. mall operator, " +
                                  "are down 21% over the last year compared with the S&P 500’s 16.6% one-year gain. And it’s still cheap compared with rival mall owners, according to Morgan Stanley, " +
                                  "which upgraded it to Overweight and raised its price target on the stock to $125." +
                                  "\r\n\r\n“While retail faces accelerating secular changes, we see multiple drivers of earnings growth for SPG,” analyst Richard Hill said in a note on Thursday. " +
                                  "His previous rating was Equalweight with a price target of $88.\r\n\r\nHis new price target implies the stock could gain 13.6% from its current price. " +
                                  "Simon Property share rose 3.8% on Thursday.\r\n\r\nEarlier this week, CEO David Simon expressed confidence that the company has “turned the corner,” offering an upbeat assessment of 2021." +
                                  "\r\n\r\nNet income this year will be in the range of $4.60 to $4.85 a share, the company projected, which would be well above analyst estimates of $3.90. " +
                                  "Funds from operations, a key financial measure for real-estate companies, will be in the range of $9.50 to $9.75 a share, above the consensus estimate of $9.49." +
                                  "\r\n\r\n“Are we completely out of the woods?” CEO Simon said on an earnings conference call. “Not yet, but we’re well on our way,”" +
                                  "\r\n\r\nThe rosy outlook offsets fourth-quarter results that fell short of expectations on two measures. Net income of $271.5 million, " +
                                  "or 86 cents a share, was just under the expected 87 cents. Funds from operations were $2.17 a share, short of the expected $2.21, according to FactSet." +
                                  "\r\n\r\nRevenue of $1.13 billion beat the consensus of $1.09 billion.\r\n\r\nSeveral analysts have raised their price targets on Simon stock this week. " +
                                  "BTIG’s James Sullivan, who also raised his target to $125, said he expects a “solid recovery” back to pre-Covid levels over the next two to three years" +
                                  ".\r\n\r\nLast year, Simon invested $330 million in several beaten-down retailers, including Brooks Brothers, Lucky Brands, Forever 21, and J.C. " +
                                  "Penney and it proceeded with a deal to buy fellow mall operator Taubman.\r\n\r\nRent collections are improving, Simon said, and negotiations with several large " +
                                  "tenants could be resolved in the next few weeks.\r\n\r\nRetailers remain cautious, he said, but a rebound in business is already happening in low-restriction areas " +
                                  "like Florida and Texas, even as Europe faces new shutdowns.\r\n\r\n“One heck of a year,” Simon said on a conference call with analysts on Monday. " +
                                  "“Let’s not repeat it in any stretch of our imagination.”",
                ImageUrl = "https://images.barrons.com/im-298112",
                ExpertComment = "There is good and bad everything, including mall REITs.  SPG is coming back, and will be making more than ever with the Taubman purchase and also the very well spent " +
                                    "money on the Forever21 etc retailers.  I  believe they announced they have already recovered 60% of their purchase price for those various stores plus did $3.5 B in online sales too."
            };
        }

        public Article GetArticleMockEight()
        {
            return new Article
            {
                Title = "Electricity to power bitcoin surges to new heights as price gets Tesla boost",
                Description =
                    "Tesla’s disclosure that it has purchased $1.5 billion of bitcoin has had the effect of sending the estimated electricity consumption of the cryptocurrency to new levels." +
                    "\r\n\r\nThe University of Cambridge’s Centre for Alternative Finance attempts to keep track of bitcoin energy consumption. While the exact consumption can never be known, " +
                    "a guess can be produced by tracking the total number of hashes produced by miners and looking at the efficiency of bitcoin mining equipment. " +
                    "The hash rate is the measuring unit of the processing power of the bitcoin network.\r\n\r\nAt an estimated 121.9 annualized terawatt hours, " +
                    "bitcoin now requires more electricity than Argentina, the United Arab Emirates or the Netherlands did for all of 2016. According to the University of Cambridge’s calculations, " +
                    "one year’s worth of bitcoin electricity consumption could power all the tea kettles of the U.K. for 27 years.\r\n\r\nWith bitcoin BTCUSD, +1.86% surging as high as $48,219 on Tuesday, " +
                    "a day after electric-car maker Tesla TSLA, +0.55% disclosed its investment in the cryptocurrency, it is more profitable to use less-efficient equipment." +
                    "\r\n\r\nAbout two-thirds of all bitcoins are mined in China, and a third of that is in Xinjiang, which has cheap coal power. The number-two center of Chinese bitcoin is in Sichuan, " +
                    "home of the Three Gorges Dam, the largest hydroelectric dam in existence.\r\n\r\nThe U.S. is in second place at just 7%, according to the University of Cambridge data, " +
                    "followed by Russia and Kazakhstan.\r\n\r\n“The obstacle that needs to be addressed is ensuring there are clean and/or efficient energy sources available for miners to tap into, " +
                    "especially during peak periods. With greater demand comes greater cost per KW, therefore incentivizing use of seldom-used coal or gas-fired plants that are falling out of " +
                    "favor from an environmental and economic perspective,” said  Jeremy Klingel of consulting firm PA Consulting.\r\n\r\nMuch like electric vehicles, " +
                    "the crypto industry could be a new avenue for load growth across the power industry, he added.\r\n\r\nConventional mining accounts for roughly 10% of global power consumption, " +
                    "compared to up to 0.5% for bitcoin mining, he said.",
                ImageUrl = "https://images.mktw.net/im-287414",
                ExpertComment =
                    "Combined Co2 emissions for this virtual nothing is not sustainable, will be it's downfall as energy prices skyrocket."
            };
        }

        public Article GetArticleMockNine()
        {
            return new Article
            {
                Title = "The GameStop Phenomenon Is Hardly New. Here’s How a Similar Squeeze Played Out in 1923.",
                Description =
                    "Long before GameStop, there was Piggly Wiggly.\n\nIn 1923, the supermarket company—which still does business in the South and Midwest—was at the center of a short squeeze/market morality play that echoes the recent frenzy around GameStop." +
                    "\n\nAs with GameStop and other “meme” companies like AMC Entertainment, Piggly Wiggly was being sold short by several big Wall Street investment firms. This aroused an unexpected popular backlash, stirred by a resentment of “city slickers” " +
                    "getting rich off the “yaps,” or little guys. So there was a sense of triumph when investors fought back and put the squeeze on the shorts.\n\n“New York speculators,” crowed one newspaper, “made to pay through the nose.”" +
                    "\n\nThe Piggly Wiggly shorts got crushed, much as Melvin Capital dropped 53% in January chiefly on its GameStop downside bets, but that wasn’t the whole story. While there were some big winners, there were also some other big " +
                    "losers—none bigger than Piggly Wiggly’s founder and president, Clarence Saunders.\n\n“After working a sensational squeeze on Piggly Wiggly,” Barron’s reported at the time, “the Memphis grocer found that his ‘victory’ had cost him about " +
                    "$3,000,000 and control of his company.” It also tarnished Saunders’ legacy.\n\nBorn in 1881, Saunders worked his way out of poverty to become a retail pioneer, turning Piggly Wiggly (the origins of the name remain obscure) into the" +
                    " nation’s first “Self-Serving Store” in 1916.\n\nThat is, instead of giving shopping lists to clerks to fill—as was practice of the day—customers walked the aisles and chose their own goods. This sublimely simple concept caught on; by " +
                    "1921 there were more than 600 Piggly Wiggly stores across the nation, and Saunders’ self-serve model is still the norm for supermarkets, from Kroger to Walmart.\n\nTo fuel continued expansion, Saunders in November 1922 announced plans " +
                    "to sell 100,000 new shares in the company. That, combined with unrelated news of a Piggly Wiggly licensee filing for bankruptcy, “caused heavy selling” in the stock, according to Barron’s, knocking the share price down to $30 from $45. " +
                    "Then Merrill Lynch and other Wall Street firms attempted a “bear raid,” shorting Piggly Wiggly stock in a bet it would fall further.\n\nSaunders cast the issue as good versus evil, asking potential investors, “Shall good business flee? " +
                    "Shall it tremble with fear? Shall it be the loot of the speculator?” as quoted in Mike Freeman’s Clarence Saunders and the Founding of Piggly Wiggly: The Rise & Fall of a Memphis Maverick.\n\nTo counter the shorts, Saunders borrowed " +
                    "$10 million on margin from a number of investors and hatched a plan to buy up all outstanding shares of Piggly Wiggly, driving the price up. The stock reached $124 on March 20, 1923—when it was suspended by the New York Stock Exchange." +
                    "\n\nThere was a “wild scramble by the shorts to cover,” Barron’s wrote, yet there was less of that than had expected. The stock showed a “declining tendency” after the shorts had covered, and “the over-the-counter market for the stock " +
                    "gradually disappeared.” In the end, “Saunders and his associates” were left with “practically the entire issue of 200,000 shares on their hands—a large part of which had been accumulated at high prices” with “no market” to sell them." +
                    "\n\nTo Barron’s, Saunders had simply suffered “the customary fate of the Main Streeter who attempts to beat Wall Street.” Indeed, just three years earlier, a short-squeeze engineered by the owner of Stutz Motor Co. ended in bankruptcy " +
                    "for both.\n\nYet there were winners in Piggly Wiggly, too, such as the retired grocer from Providence, R.I., that Freeman writes about, who bought a thousand shares at $38 before the squeeze. Expecting to use the shares as dividend " +
                    "income, the retiree instead ended up selling them “from $96 to $124” and making a profit of almost $80,000 (around $1.2 million today).\r\n\r\nThat isn’t quite of the same magnitude as the gains made by Roaring Kitty, the GameStop " +
                    "investor whose initial $53,000 stake reached a value of at least $48 million. But the reality that some players will turn a handsome profit even as others are ruined hasn’t changed over the years.\r\n\r\nToday, however, instead of one " +
                    "big investor like Saunders being left holding all the worthless shares, there may be many thousands of smaller investors facing financial strain or collapse.\r\n\r\nAs for Saunders, he went back to Tennessee, where “Memphis folk still " +
                    "have confidence” in him, as Barron’s reported at the time. But his various post–Piggle Wiggly ventures, including Keedoozle automat-style stores, met with middling success. He died in 1953, his hopes of becoming the Henry Ford of " +
                    "supermarkets undone by an ill-fated decision to take on Wall Street.\r\n\r\nWe’ll see if GameStop investors fare any better.",
                ImageUrl = "https://images.barrons.com/im-293914",
                ExpertComment =
                    "You don't have to go back to 1923. There are many cases including Volkswagen in 2008. In October 2008, Volkswagen's shares more than quadrupled in two days, briefly becoming the biggest company in the world. After Volkswagen’s peak " +
                    "in the same month, shares fell 58% in four days, and a month later the stock was down 70% from its top and gave back almost all of its gains."
            };
        }

        public Article GetArticleMockTen()
        {
            return new Article
            {
                Title = "Some Stocks Are Lagging, While the Dollar Is Rising. That’s a Buying Opportunity.",
                Description =
                    "Some economically-sensitive stocks have underperformed the broader market, while the U.S. dollar has risen. That combination makes some nervous about those stocks, but they needn’t worry." +
                    "\r\n\r\nIndustrials and banks, two highly cyclical sectors, are marginally underperforming the border market since January 6, the date that marked a reversal of the Dollar’s downtrend. " +
                    "The Industrial Select Sector SPDR Fund (XLI) has underperformed the S&P 500 by almost 4 percentage points since January 6, while the SPDR S&P Bank ETF (KBE) has underperformed by less than a tenth of a percentage point. " +
                    "Since that date, the U.S. Dollar Index (DXY) is up 1.6%.\r\n\r\nUsually, when the dollar rises, equities in general perform poorly because global investors are moving into safe haven assets as they see the " +
                    "global economic outlook weakening. “If USD were to show a notable strengthening this year, that would, to some extent, go against our bullish equity market call,” wrote JPMorgan global equity strategists in a note. " +
                    "That certainly doesn’t set up well for cyclical stocks.\r\n\r\nBut this moment is different; the dollar’s strength isn’t a refection of global risk aversion from investors, but rather a U.S. " +
                    "economy expected to perform handsomely relative to other countries for the longer-term, even as all economies rebound from the pandemic. Also, U.S. interest rates are expected to rise faster than in other countries " +
                    "over the next several years, making owning the greenback more attractive versus other currencies. That’s also consistent with the theme of U.S. economic growth outperformance." +
                    "\r\n\r\nThis all lends itself to strong performance for cyclical stocks. “Weakness in cyclicals due to Dollar gains represent buying opportunities assuming USD strength is based on improving growth prospects,” " +
                    "wrote Dennis DeBusschere, head of portfolio strategy research at Evercore in a note. “Don’t dump cyclicals because the dollar is strengthening,” Yung Yu Ma, chief investment strategist at BMO Wealth Management told Barron’s." +
                    " “Industrials and financials will do well.”\r\n\r\nGiven the positions of DeBusschere and Ma, some might be scratching their heads at why those cyclicals aren’t top performers this year. " +
                    "Actually, they have been spectacular outperformers since September 23, the start of a fresh rally in stocks and a move into assets that benefit with a strengthening economy. The Industrial " +
                    "Select Sector SPDR Fund is up 19%, roughly in line with the S&P 500’s gain. The SPDR S&P Bank ETF is up 65%. Notably, energy stocks, as seen by the Energy Select Sector SPDR Fund (XLE), " +
                    "is up 46% since that date. Ma says cyclical stocks are taking a breather, while other forgotten areas of the market catch up.\r\n\r\nBelieving in the global economy’s upturn means believing in cyclicals — " +
                    "regardless of what the dollar does.",
                ImageUrl = "https://images.barrons.com/im-296511",
                ExpertComment =
                    "Actually if one bothers to look at the DXY index, one could see, even without eye glasses, that the dollar index is at the Bottom of the toilet, 2 year bottom to be exact..." +
                    "So it’s not running anywhere. As for cyclicals, which is a terribly vague term, a lot of dilapidated names of last year staged a magnificent come back over the last few weeks: " +
                    "steels and other metal stocks have tripled, autos have doubled, so have hotel names like Hilton and Mariott. Boeing is not selling more planes, but it also doubled, so did Fedex, " +
                    "and so has the shut down Disney, and most truckers like Ryder. While left for dead because of the wrecking ball called Amazon, names like Limited , Tapestry, Kohl’s and Nordstrom’s " +
                    "have quadrupled in a few months ...\nSo we have to keep the right perspective..."
            };
        }
    }
}
