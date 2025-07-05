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

    public class DeleteUserManagerUserListRequest : AbstractModel
    {
        
        /// <summary>
        /// 集群实例ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 集群用户名列表
        /// </summary>
        [JsonProperty("UserNameList")]
        public string[] UserNameList{ get; set; }

        /// <summary>
        /// tke/eks集群id，容器集群传
        /// </summary>
        [JsonProperty("TkeClusterId")]
        public string TkeClusterId{ get; set; }

        /// <summary>
        /// 默认空，容器版传"native"
        /// </summary>
        [JsonProperty("DisplayStrategy")]
        public string DisplayStrategy{ get; set; }

        /// <summary>
        /// 用户组
        /// </summary>
        [JsonProperty("UserGroupList")]
        public UserAndGroup[] UserGroupList{ get; set; }

        /// <summary>
        /// 是否删除家目录，只针对cvm集群
        /// </summary>
        [JsonProperty("DeleteHomeDir")]
        public bool? DeleteHomeDir{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamArraySimple(map, prefix + "UserNameList.", this.UserNameList);
            this.SetParamSimple(map, prefix + "TkeClusterId", this.TkeClusterId);
            this.SetParamSimple(map, prefix + "DisplayStrategy", this.DisplayStrategy);
            this.SetParamArrayObj(map, prefix + "UserGroupList.", this.UserGroupList);
            this.SetParamSimple(map, prefix + "DeleteHomeDir", this.DeleteHomeDir);
        }
    }
}

