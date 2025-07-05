/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Live.V20180801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CasterInfo : AbstractModel
    {
        
        /// <summary>
        /// 导播台ID
        /// </summary>
        [JsonProperty("CasterId")]
        public ulong? CasterId{ get; set; }

        /// <summary>
        /// 导播台名称
        /// </summary>
        [JsonProperty("CasterName")]
        public string CasterName{ get; set; }

        /// <summary>
        /// 导播台上一次启动pgm的时间，值为unix时间戳。
        /// </summary>
        [JsonProperty("StartLiveTime")]
        public ulong? StartLiveTime{ get; set; }

        /// <summary>
        /// 导播台的描述
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 导播台创建时间，值为unix时间戳。
        /// </summary>
        [JsonProperty("CreateTime")]
        public ulong? CreateTime{ get; set; }

        /// <summary>
        /// 导播台状态 
        /// 0：停止状态，无预监，无主监
        /// 1：无预监，有主监
        /// 2：有预监，无主监
        /// 3：有预监，有主监
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// 导播台的过期时间戳。值为-1或unix时间戳。 
        /// 默认值为-1。 当值为-1时，表示该导播台永不过期。 
        /// 当值为正常unix时间戳时，导播台将在该时间过期。 
        /// 导播台过期后，预监与主监画面将自动停止，转推自动停止。 
        /// 点播、直播url将停止转拉，推流url需自行停止推流。
        /// </summary>
        [JsonProperty("ExpireTime")]
        public long? ExpireTime{ get; set; }

        /// <summary>
        /// 导播台延时播放时间，单位为秒。 
        /// </summary>
        [JsonProperty("DelayTime")]
        public ulong? DelayTime{ get; set; }

        /// <summary>
        /// 导播台主监输出的宽度，单位为像素。
        /// </summary>
        [JsonProperty("PgmWidth")]
        public ulong? PgmWidth{ get; set; }

        /// <summary>
        /// 导播台主监输出的高度，单位为像素。
        /// </summary>
        [JsonProperty("PgmHeight")]
        public ulong? PgmHeight{ get; set; }

        /// <summary>
        /// 导播台主监输出的帧率。
        /// </summary>
        [JsonProperty("PgmFps")]
        public ulong? PgmFps{ get; set; }

        /// <summary>
        /// 导播台主监输出的码率，单位为kbps
        /// </summary>
        [JsonProperty("PgmBitRate")]
        public ulong? PgmBitRate{ get; set; }

        /// <summary>
        /// 导播台主监输出的音频码率，单位为kbps。
        /// </summary>
        [JsonProperty("PgmAudioBitRate")]
        public ulong? PgmAudioBitRate{ get; set; }

        /// <summary>
        /// 导播台的计费类型。 
        /// 0 通用型 1 播单型。
        /// 注： 本参数暂无作用。
        /// </summary>
        [JsonProperty("FeeType")]
        public long? FeeType{ get; set; }

        /// <summary>
        /// 录制模板id。
        /// </summary>
        [JsonProperty("RecordTemplateId")]
        public ulong? RecordTemplateId{ get; set; }

        /// <summary>
        /// 录制状态。 
        /// 0：未录制 
        /// 1：录制中
        /// </summary>
        [JsonProperty("RecordStatus")]
        public ulong? RecordStatus{ get; set; }

        /// <summary>
        /// 录制接口返回的taskid
        /// </summary>
        [JsonProperty("RecordTaskId")]
        public string RecordTaskId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CasterId", this.CasterId);
            this.SetParamSimple(map, prefix + "CasterName", this.CasterName);
            this.SetParamSimple(map, prefix + "StartLiveTime", this.StartLiveTime);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "DelayTime", this.DelayTime);
            this.SetParamSimple(map, prefix + "PgmWidth", this.PgmWidth);
            this.SetParamSimple(map, prefix + "PgmHeight", this.PgmHeight);
            this.SetParamSimple(map, prefix + "PgmFps", this.PgmFps);
            this.SetParamSimple(map, prefix + "PgmBitRate", this.PgmBitRate);
            this.SetParamSimple(map, prefix + "PgmAudioBitRate", this.PgmAudioBitRate);
            this.SetParamSimple(map, prefix + "FeeType", this.FeeType);
            this.SetParamSimple(map, prefix + "RecordTemplateId", this.RecordTemplateId);
            this.SetParamSimple(map, prefix + "RecordStatus", this.RecordStatus);
            this.SetParamSimple(map, prefix + "RecordTaskId", this.RecordTaskId);
        }
    }
}

