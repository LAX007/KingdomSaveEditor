﻿using KHSave;
using System.Collections.Generic;
using KH02.SaveEditor.Models;
using KHSave.Models;
using KHSave.Types;
using Xe.Tools;

namespace KH02.SaveEditor.ViewModels
{
	public class PlayerViewModel : BaseNotifyPropertyChanged
	{
		private readonly PlayableCharacter playableCharacter;
		private readonly int index;

		public PlayerViewModel(PlayableCharacter playableCharacter, int index)
		{
			this.playableCharacter = playableCharacter;
			this.index = index;

			WeaponType = new GenericEnumModel<WeaponType>();
		}

		public string Name => ((PlayableCharacterType)index).ToString();

		public GenericEnumModel<WeaponType> WeaponType { get; }

		public byte AtkBoost
		{
			get => playableCharacter.AtkBoost;
			set => playableCharacter.AtkBoost = value;
		}

		public byte MagBoost
		{
			get => playableCharacter.MagBoost;
			set => playableCharacter.MagBoost = value;
		}

		public byte DefBoost
		{
			get => playableCharacter.DefBoost;
			set => playableCharacter.DefBoost = value;
		}

		public byte ApBoost
		{
			get => playableCharacter.ApBoost;
			set => playableCharacter.ApBoost = value;
		}

		public int Hp {
			get => playableCharacter.Hp;
			set => playableCharacter.Hp = value;
		}

		public int Mp
		{
			get => playableCharacter.Mp;
			set => playableCharacter.Mp = value;
		}

		public int Focus
		{
			get => playableCharacter.Focus;
			set => playableCharacter.Focus = value;
		}

		public int Weapon1Id
		{
			get => (int)playableCharacter.Weapons[0].Id;
			set
			{
				playableCharacter.Weapons[0].Id = (WeaponType)value;
				OnPropertyChanged(nameof(Weapon1));
			}
		}

		public WeaponType Weapon1
		{
			get => playableCharacter.Weapons[0].Id;
			set
			{
				playableCharacter.Weapons[0].Id = value;
				OnPropertyChanged(nameof(Weapon1Id));
			}
		}

		public int Weapon2Id
		{
			get => (int)playableCharacter.Weapons[1].Id;
			set
			{
				playableCharacter.Weapons[1].Id = (WeaponType)value;
				OnPropertyChanged(nameof(Weapon2));
			}
		}

		public WeaponType Weapon2
		{
			get => playableCharacter.Weapons[1].Id;
			set
			{
				playableCharacter.Weapons[1].Id = value;
				OnPropertyChanged(nameof(Weapon2Id));
			}
		}

		public int Weapon3Id
		{
			get => (int)playableCharacter.Weapons[2].Id;
			set
			{
				playableCharacter.Weapons[2].Id = (WeaponType)value;
				OnPropertyChanged(nameof(Weapon3));
			}
		}

		public WeaponType Weapon3
		{
			get => playableCharacter.Weapons[2].Id;
			set
			{
				playableCharacter.Weapons[2].Id = value;
				OnPropertyChanged(nameof(Weapon3Id));
			}
		}

		public IEnumerable<Ability> Abilities
		{
			get => playableCharacter.Abilities;
			set { }
		}

		public string Text => playableCharacter.ToString();
	}
}
