using System;
using System.Linq;
using OpenRpg.Combat.Processors.Attacks;
using OpenRpg.Core.State.Entity;
using OpenRpg.Genres.Scifi.Types;
using OpenRpg.Genres.Scifi.Variables;
using OpenRpg.Genres.Types;

namespace OpenRpg.Genres.Scifi.Extensions
{
    public static class ShipStateVariablesExtensions
    {
        public static int Armour(this IShipStateVariables state) => (int)state.Get(ScifiStateVariableTypes.Armour);
        public static void Armour(this IShipStateVariables state, int value) => state[ScifiStateVariableTypes.Armour] = value;
        
        public static void AddArmour(this IShipStateVariables state, int change, int? max = null)
        {
            var newValue = state.Armour() + change;
            if(newValue <= 0) { newValue = 0; }
            
            if(max == null) 
            { state.Armour(newValue); }
            else 
            {state.EnsureArmourInBounds(newValue, max.Value); }
        }

        public static void DeductArmour(this IShipStateVariables state, int change, int? max = null)
        {
            var newValue = state.Armour() - change;
            if(newValue <= 0) { newValue = 0; }
            
            if(max == null) 
            { state.Armour(newValue); }
            else 
            {state.EnsureArmourInBounds(newValue, max.Value); }
        }

        public static void EnsureArmourInBounds(this IShipStateVariables state, int value, int max)
        {
            if(value > max)
            { state[ScifiStateVariableTypes.Armour] = max; }
            else if(value <= 0)
            { state[ScifiStateVariableTypes.Armour] = 0; }
            else
            { state[ScifiStateVariableTypes.Armour] = value; }
        }
        
        public static int Shield(this IShipStateVariables state) => (int)state.Get(ScifiStateVariableTypes.Shield);
        public static void Shield(this IShipStateVariables state, int value) => state[ScifiStateVariableTypes.Shield] = value;
        
        public static void AddShield(this IShipStateVariables state, int change, int? max = null)
        {
            var newValue = state.Shield() + change;
            if(newValue <= 0) { newValue = 0; }
            
            if(max == null) 
            { state.Shield(newValue); }
            else 
            {state.EnsureShieldInBounds(newValue, max.Value); }
        }

        public static void DeductShield(this IShipStateVariables state, int change, int? max = null)
        {
            var newValue = state.Shield() - change;
            if(newValue <= 0) { newValue = 0; }
            
            if(max == null) 
            { state.Shield(newValue); }
            else 
            {state.EnsureShieldInBounds(newValue, max.Value); }
        }

        public static void EnsureShieldInBounds(this IShipStateVariables state, int value, int max)
        {
            if(value > max)
            { state[ScifiStateVariableTypes.Shield] = max; }
            else if(value <= 0)
            { state[ScifiStateVariableTypes.Shield] = 0; }
            else
            { state[ScifiStateVariableTypes.Shield] = value; }
        }
        
        public static int Energy(this IShipStateVariables state) => (int)state.Get(ScifiStateVariableTypes.Shield);
        public static void Energy(this IShipStateVariables state, int value) => state[ScifiStateVariableTypes.Shield] = value;
        
        public static void AddEnergy(this IShipStateVariables state, int change, int? max = null)
        {
            var newValue = state.Energy() + change;
            if(newValue <= 0) { newValue = 0; }
            
            if(max == null) 
            { state.Energy(newValue); }
            else 
            {state.EnsureEnergyInBounds(newValue, max.Value); }
        }

        public static void DeductEnergy(this IShipStateVariables state, int change, int? max = null)
        {
            var newValue = state.Energy() - change;
            if(newValue <= 0) { newValue = 0; }
            
            if(max == null) 
            { state.Energy(newValue); }
            else 
            {state.EnsureEnergyInBounds(newValue, max.Value); }
        }

        public static void EnsureEnergyInBounds(this IShipStateVariables state, int value, int max)
        {
            if(value > max)
            { state[ScifiStateVariableTypes.Energy] = max; }
            else if(value <= 0)
            { state[ScifiStateVariableTypes.Energy] = 0; }
            else
            { state[ScifiStateVariableTypes.Energy] = value; }
        }
        
        public static void ApplyDamageToTarget(this IShipStateVariables state, ProcessedAttack attack)
        {
            var summedAttack = attack.DamageDone.Sum(x => x.Value);
            var totalDamage = (int)Math.Round(summedAttack);
            if (totalDamage < 0) { totalDamage = 0; }
            state.DeductArmour(totalDamage);
        }
        
        public static bool IsDead(this IShipStateVariables state)
        { return state.Armour() <= 0; }
    }
}