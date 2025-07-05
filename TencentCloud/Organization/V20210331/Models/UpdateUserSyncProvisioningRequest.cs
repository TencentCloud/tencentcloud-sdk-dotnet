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

namespace TencentCloud.Organization.V20210331.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpdateUserSyncProvisioningRequest : AbstractModel
    {
        
        /// <summary>
        /// 空间ID。
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// 用户同步的iD
        /// </summary>
        [JsonProperty("UserProvisioningId")]
        public string UserProvisioningId{ get; set; }

        /// <summary>
        /// 用户同步描述。
        /// </summary>
        [JsonProperty("NewDescription")]
        public string NewDescription{ get; set; }

        /// <summary>
        /// 冲突策略。当CIC 用户同步到 CAM 时，如果 CAM 中存在同名用户时的处理策略。取值： KeepBoth：两者都保留。当CIC 用户被同步到 CAM 时，如果 CAM 已经存在同名用户，则对CIC 用户的用户名添加后缀_cic后尝试创建该用户名的 CAM 用户。 TakeOver：替换。当CIC 用户被同步到 CAM 时，如果 CAM 已经存在同名用户，则直接将已经存在的 CAM 用户替换为CIC 同步用户。 
        /// </summary>
        [JsonProperty("NewDuplicationStateful")]
        public string NewDuplicationStateful{ get; set; }

        /// <summary>
        /// 删除策略。删除 CAM 用户同步时，对已同步的 CAM 用户的处理策略。取值： Delete：删除。删除 CAM 用户同步时，会删除从CIC 已经同步到 CAM 中的 CAM 用户。 Keep：保留。删除 RAM 用户同步时，会保留从CIC 已经同步到 CAM 中的 CAM 用户。 
        /// </summary>
        [JsonProperty("NewDeletionStrategy")]
        public string NewDeletionStrategy{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "UserProvisioningId", this.UserProvisioningId);
            this.SetParamSimple(map, prefix + "NewDescription", this.NewDescription);
            this.SetParamSimple(map, prefix + "NewDuplicationStateful", this.NewDuplicationStateful);
            this.SetParamSimple(map, prefix + "NewDeletionStrategy", this.NewDeletionStrategy);
        }
    }
}

