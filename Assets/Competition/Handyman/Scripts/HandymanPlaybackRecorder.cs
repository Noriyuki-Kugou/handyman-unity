using System.Collections.Generic;
using UnityEngine;

namespace SIGVerse.Competition.Handyman
{
	[RequireComponent(typeof (HandymanPlaybackCommon))]
	public class HandymanPlaybackRecorder : TrialPlaybackRecorder
	{
		protected override void Awake()
		{
			base.isRecord = HandymanConfig.Instance.configFileInfo.playbackType == HandymanPlaybackCommon.PlaybackTypeRecord;

			base.Awake();
		}

		public bool Initialize(int numberOfTrials)
		{
			string filePath = string.Format(Application.dataPath + HandymanPlaybackCommon.FilePathFormat, numberOfTrials);

			return base.Initialize(filePath);
		}
	}
}
