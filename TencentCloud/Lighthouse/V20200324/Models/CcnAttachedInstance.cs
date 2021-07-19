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

namespace TencentCloud.Lighthouse.V20200324.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CcnAttachedInstance : AbstractModel
    {
        
        /// <summary>
        /// 云联网ID。
        /// </summary>
        [JsonProperty("CcnId")]
        public string CcnId{ get; set; }

        /// <summary>
        /// 关联实例CIDR。
        /// </summary>
        [JsonProperty("CidrBlock")]
        public string[] CidrBlock{ get; set; }

        /// <summary>
        /// 关联实例状态：
        /// 
        /// •  PENDING：申请中
        /// •  ACTIVE：已连接
        /// •  EXPIRED：已过期
        /// •  REJECTED：已拒绝
        /// •  DELETED：已删除
        /// •  FAILED：失败的（2小时后将异步强制解关联）
        /// •  ATTACHING：关联中
        /// •  DETACHING：解关联中
        /// •  DETACHFAILED：解关联失败（2小时后将异步强制解关联）
        /// </summary>
        [JsonProperty("State")]
        public string State{ get; set; }

        /// <summary>
        /// 关联时间。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AttachedTime")]
        public string AttachedTime{ get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CcnId", this.CcnId);
            this.SetParamArraySimple(map, prefix + "CidrBlock.", this.CidrBlock);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "AttachedTime", this.AttachedTime);
            this.SetParamSimple(map, prefix + "Description", this.Description);
        }
    }
}

