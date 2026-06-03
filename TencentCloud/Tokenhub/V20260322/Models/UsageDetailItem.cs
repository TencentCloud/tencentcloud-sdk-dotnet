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

namespace TencentCloud.Tokenhub.V20260322.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UsageDetailItem : AbstractModel
    {
        
        /// <summary>
        /// 主账号 UIN。
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// 模型名称。
        /// </summary>
        [JsonProperty("ModelName")]
        public string ModelName{ get; set; }

        /// <summary>
        /// APIKey ID。
        /// </summary>
        [JsonProperty("ApiKeyId")]
        public string ApiKeyId{ get; set; }

        /// <summary>
        /// APIKey 名称。
        /// </summary>
        [JsonProperty("ApiKeyName")]
        public string ApiKeyName{ get; set; }

        /// <summary>
        /// 请求 ID。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }

        /// <summary>
        /// 请求时间（RFC3339 格式）。
        /// </summary>
        [JsonProperty("RequestTime")]
        public string RequestTime{ get; set; }

        /// <summary>
        /// 输入 token 数。
        /// </summary>
        [JsonProperty("InputToken")]
        public long? InputToken{ get; set; }

        /// <summary>
        /// 缓存 token 数。
        /// </summary>
        [JsonProperty("CacheToken")]
        public long? CacheToken{ get; set; }

        /// <summary>
        /// 输出 token 数。
        /// </summary>
        [JsonProperty("OutputToken")]
        public long? OutputToken{ get; set; }

        /// <summary>
        /// 总 token 数。
        /// </summary>
        [JsonProperty("TotalToken")]
        public long? TotalToken{ get; set; }

        /// <summary>
        /// 未命中缓存输入消耗额度。单位说明如下：
        /// - 套餐类型为专业套餐（enterprise），单位取值为积分；
        /// - 套餐类型轻享套餐（enterprise-auto），单位取值为 token。
        /// </summary>
        [JsonProperty("InputQuota")]
        public string InputQuota{ get; set; }

        /// <summary>
        /// 缓存消耗额度。单位说明如下：
        /// - 套餐类型为专业套餐（enterprise），单位取值为积分；
        /// - 套餐类型轻享套餐（enterprise-auto），单位取值为 token。
        /// </summary>
        [JsonProperty("CacheQuota")]
        public string CacheQuota{ get; set; }

        /// <summary>
        /// 输出消耗额度。单位说明如下：
        /// - 套餐类型为专业套餐（enterprise），单位取值为积分；
        /// - 套餐类型轻享套餐（enterprise-auto），单位取值为 token。
        /// </summary>
        [JsonProperty("OutputQuota")]
        public string OutputQuota{ get; set; }

        /// <summary>
        /// 总消耗额度。单位说明如下：
        /// - 套餐类型为专业套餐（enterprise），单位取值为积分；
        /// - 套餐类型轻享套餐（enterprise-auto），单位取值为 token。
        /// </summary>
        [JsonProperty("TotalQuota")]
        public string TotalQuota{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "ModelName", this.ModelName);
            this.SetParamSimple(map, prefix + "ApiKeyId", this.ApiKeyId);
            this.SetParamSimple(map, prefix + "ApiKeyName", this.ApiKeyName);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
            this.SetParamSimple(map, prefix + "RequestTime", this.RequestTime);
            this.SetParamSimple(map, prefix + "InputToken", this.InputToken);
            this.SetParamSimple(map, prefix + "CacheToken", this.CacheToken);
            this.SetParamSimple(map, prefix + "OutputToken", this.OutputToken);
            this.SetParamSimple(map, prefix + "TotalToken", this.TotalToken);
            this.SetParamSimple(map, prefix + "InputQuota", this.InputQuota);
            this.SetParamSimple(map, prefix + "CacheQuota", this.CacheQuota);
            this.SetParamSimple(map, prefix + "OutputQuota", this.OutputQuota);
            this.SetParamSimple(map, prefix + "TotalQuota", this.TotalQuota);
        }
    }
}

