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

namespace TencentCloud.Cdwdoris.V20211228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyUserPrivilegesV3Request : AbstractModel
    {
        
        /// <summary>
        /// 集群id
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// 用户权限
        /// </summary>
        [JsonProperty("UserPrivileges")]
        public UpdateUserPrivileges UserPrivileges{ get; set; }

        /// <summary>
        /// 用户链接来自的 IP	
        /// </summary>
        [JsonProperty("WhiteHost")]
        public string WhiteHost{ get; set; }

        /// <summary>
        /// 更新类型，默认0，1为更新绑定计算组
        /// </summary>
        [JsonProperty("UpdateType")]
        public long? UpdateType{ get; set; }

        /// <summary>
        /// 需绑定计算组列表
        /// </summary>
        [JsonProperty("UpdateComputeGroups")]
        public string[] UpdateComputeGroups{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
            this.SetParamObj(map, prefix + "UserPrivileges.", this.UserPrivileges);
            this.SetParamSimple(map, prefix + "WhiteHost", this.WhiteHost);
            this.SetParamSimple(map, prefix + "UpdateType", this.UpdateType);
            this.SetParamArraySimple(map, prefix + "UpdateComputeGroups.", this.UpdateComputeGroups);
        }
    }
}

