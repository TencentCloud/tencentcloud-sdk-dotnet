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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CcnAttachedInstance : AbstractModel
    {
        
        /// <summary>
        /// 云联网实例ID。
        /// </summary>
        [JsonProperty("CcnId")]
        public string CcnId{ get; set; }

        /// <summary>
        /// 关联实例类型：
        /// <li>`VPC`：私有网络</li>
        /// <li>`DIRECTCONNECT`：专线网关</li>
        /// <li>`BMVPC`：黑石私有网络</li>
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// 关联实例ID。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 关联实例名称。
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// 关联实例所属大区，例如：ap-guangzhou。
        /// </summary>
        [JsonProperty("InstanceRegion")]
        public string InstanceRegion{ get; set; }

        /// <summary>
        /// 关联实例所属UIN（根账号）。
        /// </summary>
        [JsonProperty("InstanceUin")]
        public string InstanceUin{ get; set; }

        /// <summary>
        /// 关联实例CIDR。
        /// </summary>
        [JsonProperty("CidrBlock")]
        public string[] CidrBlock{ get; set; }

        /// <summary>
        /// 关联实例状态：
        /// <li>`PENDING`：申请中</li>
        /// <li>`ACTIVE`：已连接</li>
        /// <li>`EXPIRED`：已过期</li>
        /// <li>`REJECTED`：已拒绝</li>
        /// <li>`DELETED`：已删除</li>
        /// <li>`FAILED`：失败的（2小时后将异步强制解关联）</li>
        /// <li>`ATTACHING`：关联中</li>
        /// <li>`DETACHING`：解关联中</li>
        /// <li>`DETACHFAILED`：解关联失败（2小时后将异步强制解关联）</li>
        /// </summary>
        [JsonProperty("State")]
        public string State{ get; set; }

        /// <summary>
        /// 关联时间。
        /// </summary>
        [JsonProperty("AttachedTime")]
        public string AttachedTime{ get; set; }

        /// <summary>
        /// 云联网所属UIN（根账号）。
        /// </summary>
        [JsonProperty("CcnUin")]
        public string CcnUin{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CcnId", this.CcnId);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "InstanceRegion", this.InstanceRegion);
            this.SetParamSimple(map, prefix + "InstanceUin", this.InstanceUin);
            this.SetParamArraySimple(map, prefix + "CidrBlock.", this.CidrBlock);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "AttachedTime", this.AttachedTime);
            this.SetParamSimple(map, prefix + "CcnUin", this.CcnUin);
        }
    }
}

