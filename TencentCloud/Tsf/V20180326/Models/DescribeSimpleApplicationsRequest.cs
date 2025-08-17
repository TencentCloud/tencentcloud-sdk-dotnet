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

namespace TencentCloud.Tsf.V20180326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeSimpleApplicationsRequest : AbstractModel
    {
        
        /// <summary>
        /// 应用ID列表，可通过调用[DescribeApplications](https://cloud.tencent.com/document/api/649/36090)查询已创建的应用列表或登录控制台进行查看；也可以调用[CreateApplication](https://cloud.tencent.com/document/api/649/36094)创建新的应用。
        /// </summary>
        [JsonProperty("ApplicationIdList")]
        public string[] ApplicationIdList{ get; set; }

        /// <summary>
        /// 指定应用类型，目前支持：
        /// - `V`：普通应用/CVM应用
        /// - `C`：容器应用
        /// - `S`：serverless 应用
        /// </summary>
        [JsonProperty("ApplicationType")]
        public string ApplicationType{ get; set; }

        /// <summary>
        /// 数量限制，默认为20，最大值为100。关于Limit详见[API简介](https://cloud.tencent.com/document/api/213/568#.E8.BE.93.E5.85.A5.E5.8F.82.E6.95.B0.E4.B8.8E.E8.BF.94.E5.9B.9E.E5.8F.82.E6.95.B0.E9.87.8A.E4.B9.89)
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 偏移量，默认为0。关于Offset详见[API简介](https://cloud.tencent.com/document/api/213/568#.E8.BE.93.E5.85.A5.E5.8F.82.E6.95.B0.E4.B8.8E.E8.BF.94.E5.9B.9E.E5.8F.82.E6.95.B0.E9.87.8A.E4.B9.89)
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 微服务类型
        /// </summary>
        [JsonProperty("MicroserviceType")]
        public string MicroserviceType{ get; set; }

        /// <summary>
        /// 应用资源类型列表；DEF 表示默认资源类型；GW 表示网关资源类型
        /// </summary>
        [JsonProperty("ApplicationResourceTypeList")]
        public string[] ApplicationResourceTypeList{ get; set; }

        /// <summary>
        /// 通过id和name进行关键词过滤
        /// </summary>
        [JsonProperty("SearchWord")]
        public string SearchWord{ get; set; }

        /// <summary>
        /// 是否关闭鉴权查询
        /// </summary>
        [JsonProperty("DisableProgramAuthCheck")]
        public bool? DisableProgramAuthCheck{ get; set; }

        /// <summary>
        /// 查询指定微服务类型的应用列表
        /// </summary>
        [JsonProperty("MicroserviceTypeList")]
        public string[] MicroserviceTypeList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "ApplicationIdList.", this.ApplicationIdList);
            this.SetParamSimple(map, prefix + "ApplicationType", this.ApplicationType);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "MicroserviceType", this.MicroserviceType);
            this.SetParamArraySimple(map, prefix + "ApplicationResourceTypeList.", this.ApplicationResourceTypeList);
            this.SetParamSimple(map, prefix + "SearchWord", this.SearchWord);
            this.SetParamSimple(map, prefix + "DisableProgramAuthCheck", this.DisableProgramAuthCheck);
            this.SetParamArraySimple(map, prefix + "MicroserviceTypeList.", this.MicroserviceTypeList);
        }
    }
}

