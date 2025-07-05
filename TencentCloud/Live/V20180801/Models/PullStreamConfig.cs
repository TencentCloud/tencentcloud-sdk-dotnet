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

    public class PullStreamConfig : AbstractModel
    {
        
        /// <summary>
        /// 拉流配置 ID。
        /// </summary>
        [JsonProperty("ConfigId")]
        public string ConfigId{ get; set; }

        /// <summary>
        /// 源 URL。
        /// </summary>
        [JsonProperty("FromUrl")]
        public string FromUrl{ get; set; }

        /// <summary>
        /// 目的 URL。
        /// </summary>
        [JsonProperty("ToUrl")]
        public string ToUrl{ get; set; }

        /// <summary>
        /// 区域名。
        /// </summary>
        [JsonProperty("AreaName")]
        public string AreaName{ get; set; }

        /// <summary>
        /// 运营商名。
        /// </summary>
        [JsonProperty("IspName")]
        public string IspName{ get; set; }

        /// <summary>
        /// 开始时间。
        /// UTC格式时间，例如: 2019-01-08T10:00:00Z。
        /// 注意：北京时间值为 UTC 时间值 + 8 小时，格式按照 ISO 8601 标准表示，详见 [ISO 日期格式说明](https://cloud.tencent.com/document/product/266/11732#I)。
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 结束时间。
        /// 
        /// UTC格式时间，例如：2019-01-08T10:00:00Z。
        /// 注意：北京时间值为 UTC 时间值 + 8 小时，格式按照 ISO 8601 标准表示，详见 [ISO 日期格式说明](https://cloud.tencent.com/document/product/266/11732#I)。
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 状态:
        /// 0: 无效。
        /// 1: 初始状态。
        /// 2: 正在运行。
        /// 3: 拉起失败。
        /// 4: 暂停。
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ConfigId", this.ConfigId);
            this.SetParamSimple(map, prefix + "FromUrl", this.FromUrl);
            this.SetParamSimple(map, prefix + "ToUrl", this.ToUrl);
            this.SetParamSimple(map, prefix + "AreaName", this.AreaName);
            this.SetParamSimple(map, prefix + "IspName", this.IspName);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Status", this.Status);
        }
    }
}

