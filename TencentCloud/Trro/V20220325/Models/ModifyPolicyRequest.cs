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

namespace TencentCloud.Trro.V20220325.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyPolicyRequest : AbstractModel
    {
        
        /// <summary>
        /// 修改权限配置的项目ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 修改权限配置的远端设备ID
        /// </summary>
        [JsonProperty("RemoteDeviceId")]
        public string RemoteDeviceId{ get; set; }

        /// <summary>
        /// 权限修改涉及的现场设备ID数组
        /// </summary>
        [JsonProperty("FieldDeviceIds")]
        public string[] FieldDeviceIds{ get; set; }

        /// <summary>
        /// 修改的目标权限模式，black为黑名单，white为白名单
        /// </summary>
        [JsonProperty("PolicyMode")]
        public string PolicyMode{ get; set; }

        /// <summary>
        /// 修改模式，add为新增（添加现场设备I关联），remove为删除（解除现场设备关联），set为设置（更新现场设备关联）
        /// </summary>
        [JsonProperty("ModifyMode")]
        public string ModifyMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "RemoteDeviceId", this.RemoteDeviceId);
            this.SetParamArraySimple(map, prefix + "FieldDeviceIds.", this.FieldDeviceIds);
            this.SetParamSimple(map, prefix + "PolicyMode", this.PolicyMode);
            this.SetParamSimple(map, prefix + "ModifyMode", this.ModifyMode);
        }
    }
}

