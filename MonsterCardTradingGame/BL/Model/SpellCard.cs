﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterCardTradingGame.Model
{
    class SpellCard : Card
    {
        public ElementTypes ElementType { get; set; }

        public SpellCard(string cardID, string title, float damage, ElementTypes elementType, string description = "")
            : base(cardID, title, damage, description)
        {
            ElementType = elementType;
        }
    }
}