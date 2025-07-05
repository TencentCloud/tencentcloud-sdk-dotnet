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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AreaCLSTargetInfo : AbstractModel
    {
        
        /// <summary>
        /// 日志集所属地区：
        /// <li>ap-guangzhou：广州；</li>
        /// <li>ap-beijing：北京；</li>
        /// <li>ap-chengdu：成都；</li>
        /// <li>ap-chongqing：重庆；</li>
        /// <li>ap-nanjing：南京；</li>
        /// <li>ap-shanghai：上海；</li>
        /// <li>ap-singapore：新加坡。</li>
        /// </summary>
        [JsonProperty("CLSRegion")]
        public string CLSRegion{ get; set; }

        /// <summary>
        /// 投递的目标主题 ID。
        /// </summary>
        [JsonProperty("TopicId")]
        public string TopicId{ get; set; }

        /// <summary>
        /// 投递的目标集 ID。
        /// </summary>
        [JsonProperty("LogsetId")]
        public string LogsetId{ get; set; }

        /// <summary>
        /// 日志投递状态。
        ///  ON：启用；
        ///  OFF：停用。
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CLSRegion", this.CLSRegion);
            this.SetParamSimple(map, prefix + "TopicId", this.TopicId);
            this.SetParamSimple(map, prefix + "LogsetId", this.LogsetId);
            this.SetParamSimple(map, prefix + "Switch", this.Switch);
        }
    }
}

