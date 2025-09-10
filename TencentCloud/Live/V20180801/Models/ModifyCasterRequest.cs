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

    public class ModifyCasterRequest : AbstractModel
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
        /// 导播台的描述，最大允许长度256
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 录制模板id。
        /// 默认为0。
        /// 当使用直播录制功能时，可将使用的录制模版填入。
        /// 该接口仅保存字段，不涉及任何录制功能。
        /// </summary>
        [JsonProperty("RecordTemplateId")]
        public ulong? RecordTemplateId{ get; set; }

        /// <summary>
        /// 录制状态，当调用录制接口后，可通过该字段保存录制状态。
        /// 0：未录制 
        /// 1：录制中
        /// 该接口仅保存字段，不涉及任何录制处理。
        /// </summary>
        [JsonProperty("RecordStatus")]
        public ulong? RecordStatus{ get; set; }

        /// <summary>
        /// 导播台的过期时间戳。值为-1或unix时间戳。
        /// 默认值为-1。 
        /// 当值为-1时，表示该导播台永不过期。 
        /// 当值为正常unix时间戳时，导播台将在该时间过期。
        /// 导播台过期后，预监与主监画面将自动停止，转推自动停止。 
        /// 点播、直播url将停止转拉，推流url需自行停止推流。
        /// </summary>
        [JsonProperty("ExpireTime")]
        public long? ExpireTime{ get; set; }

        /// <summary>
        /// 导播台延时播放时间，单位为秒。 
        /// 默认为0，最大支持300秒
        /// </summary>
        [JsonProperty("DelayTime")]
        public ulong? DelayTime{ get; set; }

        /// <summary>
        /// 导播台转场类型。 
        /// 默认为空。 
        /// 允许使用通过DescribeCasterTransitionTypes接口中查询到的转场类型。
        /// </summary>
        [JsonProperty("TransitionType")]
        public string TransitionType{ get; set; }

        /// <summary>
        /// 导播台主监输出的宽度，单位为像素。 
        /// 默认为1280，最大允许4096。
        /// </summary>
        [JsonProperty("PgmWidth")]
        public ulong? PgmWidth{ get; set; }

        /// <summary>
        /// 导播台主监输出的高度，单位为像素。 
        /// 默认为720，最大允许2160。
        /// </summary>
        [JsonProperty("PgmHeight")]
        public ulong? PgmHeight{ get; set; }

        /// <summary>
        /// 导播台主监输出的帧率。 
        /// 默认为0，表示随源输出。 最大支持60。
        /// </summary>
        [JsonProperty("PgmFps")]
        public ulong? PgmFps{ get; set; }

        /// <summary>
        /// 导播台主监输出的码率，单位为kbps。 
        /// 默认为0，表示随源的码率输出。 
        /// 最大允许10000kbps。
        /// </summary>
        [JsonProperty("PgmBitRate")]
        public ulong? PgmBitRate{ get; set; }

        /// <summary>
        /// 导播台的计费类型。 
        /// 0 通用型 
        /// 1 播单型。 
        /// 注： 本参数暂无作用。
        /// </summary>
        [JsonProperty("FeeType")]
        public long? FeeType{ get; set; }

        /// <summary>
        /// 录制接口返回的taskid
        /// 注：该接口只做字段保存，不涉及录制操作。
        /// </summary>
        [JsonProperty("RecordTaskId")]
        public string RecordTaskId{ get; set; }

        /// <summary>
        /// 导播台主监输出的音频码率，单位为kbps。 
        /// 可选项：[0, 128, 192, 256] 
        /// 默认值为0，表示随源的音频码率输出。
        /// </summary>
        [JsonProperty("PgmAudioBitRate")]
        public ulong? PgmAudioBitRate{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CasterId", this.CasterId);
            this.SetParamSimple(map, prefix + "CasterName", this.CasterName);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "RecordTemplateId", this.RecordTemplateId);
            this.SetParamSimple(map, prefix + "RecordStatus", this.RecordStatus);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "DelayTime", this.DelayTime);
            this.SetParamSimple(map, prefix + "TransitionType", this.TransitionType);
            this.SetParamSimple(map, prefix + "PgmWidth", this.PgmWidth);
            this.SetParamSimple(map, prefix + "PgmHeight", this.PgmHeight);
            this.SetParamSimple(map, prefix + "PgmFps", this.PgmFps);
            this.SetParamSimple(map, prefix + "PgmBitRate", this.PgmBitRate);
            this.SetParamSimple(map, prefix + "FeeType", this.FeeType);
            this.SetParamSimple(map, prefix + "RecordTaskId", this.RecordTaskId);
            this.SetParamSimple(map, prefix + "PgmAudioBitRate", this.PgmAudioBitRate);
        }
    }
}

