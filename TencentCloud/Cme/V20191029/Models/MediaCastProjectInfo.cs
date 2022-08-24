/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Cme.V20191029.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MediaCastProjectInfo : AbstractModel
    {
        
        /// <summary>
        /// 点播转直播项目状态，取值有：
        /// <li>Working ：运行中；</li>
        /// <li>Idle ：空闲。</li>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 输入源列表。
        /// </summary>
        [JsonProperty("SourceInfos")]
        public MediaCastSourceInfo[] SourceInfos{ get; set; }

        /// <summary>
        /// 输出源列表。
        /// </summary>
        [JsonProperty("DestinationInfos")]
        public MediaCastDestinationInfo[] DestinationInfos{ get; set; }

        /// <summary>
        /// 输出媒体配置。
        /// </summary>
        [JsonProperty("OutputMediaSetting")]
        public MediaCastOutputMediaSetting OutputMediaSetting{ get; set; }

        /// <summary>
        /// 播放参数。
        /// </summary>
        [JsonProperty("PlaySetting")]
        public MediaCastPlaySetting PlaySetting{ get; set; }

        /// <summary>
        /// 项目启动时间。采用 [ISO 日期格式](https://cloud.tencent.com/document/product/266/11732#I)。
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 项目结束时间。采用 [ISO 日期格式](https://cloud.tencent.com/document/product/266/11732#I)。如果项目还在运行中，改字段为空。
        /// </summary>
        [JsonProperty("StopTime")]
        public string StopTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArrayObj(map, prefix + "SourceInfos.", this.SourceInfos);
            this.SetParamArrayObj(map, prefix + "DestinationInfos.", this.DestinationInfos);
            this.SetParamObj(map, prefix + "OutputMediaSetting.", this.OutputMediaSetting);
            this.SetParamObj(map, prefix + "PlaySetting.", this.PlaySetting);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "StopTime", this.StopTime);
        }
    }
}

