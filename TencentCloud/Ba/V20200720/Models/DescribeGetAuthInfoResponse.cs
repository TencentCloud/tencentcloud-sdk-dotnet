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

namespace TencentCloud.Ba.V20200720.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeGetAuthInfoResponse : AbstractModel
    {
        
        /// <summary>
        /// 实名认证状态：0未实名，1已实名
        /// </summary>
        [JsonProperty("IsTenPayMasked")]
        public string IsTenPayMasked{ get; set; }

        /// <summary>
        /// 实名认证类型：0个人，1企业
        /// </summary>
        [JsonProperty("IsAuthenticated")]
        public string IsAuthenticated{ get; set; }

        /// <summary>
        /// 认证类型，个人0，企业1
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IsTenPayMasked", this.IsTenPayMasked);
            this.SetParamSimple(map, prefix + "IsAuthenticated", this.IsAuthenticated);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

