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

    public class QpsData : AbstractModel
    {
        
        /// <summary>
        /// <p>弹性qps默认值</p>
        /// </summary>
        [JsonProperty("ElasticBillingDefault")]
        public ulong? ElasticBillingDefault{ get; set; }

        /// <summary>
        /// <p>弹性qps最小值</p>
        /// </summary>
        [JsonProperty("ElasticBillingMin")]
        public ulong? ElasticBillingMin{ get; set; }

        /// <summary>
        /// <p>弹性qps最大值</p>
        /// </summary>
        [JsonProperty("ElasticBillingMax")]
        public ulong? ElasticBillingMax{ get; set; }

        /// <summary>
        /// <p>业务扩展包最大qps</p>
        /// </summary>
        [JsonProperty("QPSExtendMax")]
        public ulong? QPSExtendMax{ get; set; }

        /// <summary>
        /// <p>境外业务扩展包最大qps</p>
        /// </summary>
        [JsonProperty("QPSExtendIntlMax")]
        public ulong? QPSExtendIntlMax{ get; set; }

        /// <summary>
        /// <p>预付费/后付费QPS扩容比</p>
        /// </summary>
        [JsonProperty("ElasticPrepaidRatio")]
        public float? ElasticPrepaidRatio{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ElasticBillingDefault", this.ElasticBillingDefault);
            this.SetParamSimple(map, prefix + "ElasticBillingMin", this.ElasticBillingMin);
            this.SetParamSimple(map, prefix + "ElasticBillingMax", this.ElasticBillingMax);
            this.SetParamSimple(map, prefix + "QPSExtendMax", this.QPSExtendMax);
            this.SetParamSimple(map, prefix + "QPSExtendIntlMax", this.QPSExtendIntlMax);
            this.SetParamSimple(map, prefix + "ElasticPrepaidRatio", this.ElasticPrepaidRatio);
        }
    }
}

