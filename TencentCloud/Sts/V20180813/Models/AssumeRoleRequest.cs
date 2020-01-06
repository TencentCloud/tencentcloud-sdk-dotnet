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

namespace TencentCloud.Sts.V20180813.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AssumeRoleRequest : AbstractModel
    {
        
        /// <summary>
        /// 角色的资源描述。例如：qcs::cam::uin/12345678:role/4611686018427397919、qcs::cam::uin/12345678:roleName/testRoleName
        /// </summary>
        [JsonProperty("RoleArn")]
        public string RoleArn{ get; set; }

        /// <summary>
        /// 临时会话名称，由用户自定义名称
        /// </summary>
        [JsonProperty("RoleSessionName")]
        public string RoleSessionName{ get; set; }

        /// <summary>
        /// 指定临时证书的有效期，单位：秒，默认 7200 秒，最长可设定有效期为 43200 秒
        /// </summary>
        [JsonProperty("DurationSeconds")]
        public ulong? DurationSeconds{ get; set; }

        /// <summary>
        /// 策略描述
        /// 注意：
        /// 1、policy 需要做 urlencode（如果通过 GET 方法请求云 API，发送请求前，所有参数都需要按照[云 API 规范](https://cloud.tencent.com/document/api/598/33159#1.-.E6.8B.BC.E6.8E.A5.E8.A7.84.E8.8C.83.E8.AF.B7.E6.B1.82.E4.B8.B2)再 urlencode 一次）。
        /// 2、策略语法参照[ CAM 策略语法](https://cloud.tencent.com/document/product/598/10603)。
        /// 3、策略中不能包含 principal 元素。
        /// </summary>
        [JsonProperty("Policy")]
        public string Policy{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RoleArn", this.RoleArn);
            this.SetParamSimple(map, prefix + "RoleSessionName", this.RoleSessionName);
            this.SetParamSimple(map, prefix + "DurationSeconds", this.DurationSeconds);
            this.SetParamSimple(map, prefix + "Policy", this.Policy);
        }
    }
}

