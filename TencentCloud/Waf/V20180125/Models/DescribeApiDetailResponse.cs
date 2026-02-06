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

namespace TencentCloud.Waf.V20180125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeApiDetailResponse : AbstractModel
    {
        
        /// <summary>
        /// 请求样例，json字符串格式
        /// </summary>
        [JsonProperty("Log")]
        public string Log{ get; set; }

        /// <summary>
        /// 完整请求样例
        /// </summary>
        [JsonProperty("FullReqLog")]
        public string FullReqLog{ get; set; }

        /// <summary>
        /// 请求参数样例列表
        /// </summary>
        [JsonProperty("ParameterList")]
        public ApiParameterType[] ParameterList{ get; set; }

        /// <summary>
        /// 当前场景标签
        /// </summary>
        [JsonProperty("Scene")]
        public string Scene{ get; set; }

        /// <summary>
        /// 敏感字段
        /// </summary>
        [JsonProperty("SensitiveFields")]
        public string[] SensitiveFields{ get; set; }

        /// <summary>
        /// 7天内是否活跃
        /// </summary>
        [JsonProperty("IsActive")]
        public bool? IsActive{ get; set; }

        /// <summary>
        /// 访问ip数
        /// </summary>
        [JsonProperty("IpCount")]
        public long? IpCount{ get; set; }

        /// <summary>
        /// 访问地域数量
        /// </summary>
        [JsonProperty("RegionCount")]
        public long? RegionCount{ get; set; }

        /// <summary>
        /// 关联事件数
        /// </summary>
        [JsonProperty("EventCount")]
        public long? EventCount{ get; set; }

        /// <summary>
        /// 涉敏数据条数
        /// </summary>
        [JsonProperty("SensitiveCount")]
        public ulong? SensitiveCount{ get; set; }

        /// <summary>
        /// 风险等级
        /// </summary>
        [JsonProperty("Level")]
        public ulong? Level{ get; set; }

        /// <summary>
        /// 响应体
        /// </summary>
        [JsonProperty("RspLog")]
        public string RspLog{ get; set; }

        /// <summary>
        /// 昨日访问峰值QPS
        /// </summary>
        [JsonProperty("MaxQPS")]
        public ulong? MaxQPS{ get; set; }

        /// <summary>
        /// 历史样例
        /// </summary>
        [JsonProperty("ApiDetailSampleHistory")]
        public ApiDetailSampleHistory[] ApiDetailSampleHistory{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Log", this.Log);
            this.SetParamSimple(map, prefix + "FullReqLog", this.FullReqLog);
            this.SetParamArrayObj(map, prefix + "ParameterList.", this.ParameterList);
            this.SetParamSimple(map, prefix + "Scene", this.Scene);
            this.SetParamArraySimple(map, prefix + "SensitiveFields.", this.SensitiveFields);
            this.SetParamSimple(map, prefix + "IsActive", this.IsActive);
            this.SetParamSimple(map, prefix + "IpCount", this.IpCount);
            this.SetParamSimple(map, prefix + "RegionCount", this.RegionCount);
            this.SetParamSimple(map, prefix + "EventCount", this.EventCount);
            this.SetParamSimple(map, prefix + "SensitiveCount", this.SensitiveCount);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "RspLog", this.RspLog);
            this.SetParamSimple(map, prefix + "MaxQPS", this.MaxQPS);
            this.SetParamArrayObj(map, prefix + "ApiDetailSampleHistory.", this.ApiDetailSampleHistory);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

