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

namespace TencentCloud.Clb.V20180317.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModelRouterLog : AbstractModel
    {
        
        /// <summary>
        /// <p>API Key的ID</p>
        /// </summary>
        [JsonProperty("KeyId")]
        public string KeyId{ get; set; }

        /// <summary>
        /// <p>模型</p>
        /// </summary>
        [JsonProperty("Model")]
        public string Model{ get; set; }

        /// <summary>
        /// <p>所属厂商</p>
        /// </summary>
        [JsonProperty("Provider")]
        public string Provider{ get; set; }

        /// <summary>
        /// <p>请求状态</p><p>枚举值：</p><ul><li>failure： 失败</li><li>success： 成功</li></ul>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>最大重试次数</p>
        /// </summary>
        [JsonProperty("MaxRetries")]
        public ulong? MaxRetries{ get; set; }

        /// <summary>
        /// <p>单次请求消耗的总Token数量</p>
        /// </summary>
        [JsonProperty("TotalTokens")]
        public ulong? TotalTokens{ get; set; }

        /// <summary>
        /// <p>单次请求输入消耗的Token数量</p>
        /// </summary>
        [JsonProperty("InputTokens")]
        public ulong? InputTokens{ get; set; }

        /// <summary>
        /// <p>单次请求输出消耗的Token数量</p>
        /// </summary>
        [JsonProperty("OutputTokens")]
        public ulong? OutputTokens{ get; set; }

        /// <summary>
        /// <p>请求耗时</p><p>单位：ms</p>
        /// </summary>
        [JsonProperty("RequestDuration")]
        public ulong? RequestDuration{ get; set; }

        /// <summary>
        /// <p>请求IP</p>
        /// </summary>
        [JsonProperty("RequesterIp")]
        public string RequesterIp{ get; set; }

        /// <summary>
        /// <p>日志查询起始时间</p>
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// <p>日志查询结束时间</p>
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "KeyId", this.KeyId);
            this.SetParamSimple(map, prefix + "Model", this.Model);
            this.SetParamSimple(map, prefix + "Provider", this.Provider);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "MaxRetries", this.MaxRetries);
            this.SetParamSimple(map, prefix + "TotalTokens", this.TotalTokens);
            this.SetParamSimple(map, prefix + "InputTokens", this.InputTokens);
            this.SetParamSimple(map, prefix + "OutputTokens", this.OutputTokens);
            this.SetParamSimple(map, prefix + "RequestDuration", this.RequestDuration);
            this.SetParamSimple(map, prefix + "RequesterIp", this.RequesterIp);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
        }
    }
}

