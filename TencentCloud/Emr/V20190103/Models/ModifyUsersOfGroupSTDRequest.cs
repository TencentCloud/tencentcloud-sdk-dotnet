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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyUsersOfGroupSTDRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>集群名称</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>用户组名</p>
        /// </summary>
        [JsonProperty("Group")]
        public string Group{ get; set; }

        /// <summary>
        /// <p>用户列表</p>
        /// </summary>
        [JsonProperty("Users")]
        public string[] Users{ get; set; }

        /// <summary>
        /// <p>用户组描述</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>枚举类, ADD, DELETE, SYNC</p><p>枚举类说明:</p><ul><li>ADD: 新增的批量用户, 多次新增相同的用户不会报错</li><li>DELETE: 从用户组里删除的批量用户, 删除不存在的用户不会报错</li><li>SYNC: 用于同步整个用户组, 当列表为空时代表清空整个用户组<br>默认为SYNC</li></ul>
        /// </summary>
        [JsonProperty("OperateAction")]
        public string OperateAction{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Group", this.Group);
            this.SetParamArraySimple(map, prefix + "Users.", this.Users);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "OperateAction", this.OperateAction);
        }
    }
}

