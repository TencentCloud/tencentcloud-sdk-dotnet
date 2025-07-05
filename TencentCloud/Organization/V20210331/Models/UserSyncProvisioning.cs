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

    public class UserSyncProvisioning : AbstractModel
    {
        
        /// <summary>
        /// 描述。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// CAM 用户同步的身份 ID。取值：
        /// 当PrincipalType取值为Group时，该值为CIC用户组 ID（g-********）。
        /// 当PrincipalType取值为User时，该值为CIC用户 ID（u-********）。
        /// </summary>
        [JsonProperty("PrincipalId")]
        public string PrincipalId{ get; set; }

        /// <summary>
        /// CAM 用户同步的身份类型。取值：
        /// 
        /// User：表示该 CAM 用户同步的身份是CIC用户。
        /// Group：表示该 CAM 用户同步的身份是CIC用户组。
        /// </summary>
        [JsonProperty("PrincipalType")]
        public string PrincipalType{ get; set; }

        /// <summary>
        /// 同步的集团账号目标账号的UIN。
        /// </summary>
        [JsonProperty("TargetUin")]
        public long? TargetUin{ get; set; }

        /// <summary>
        /// 冲突策略。当CIC 用户同步到 CAM 时，如果 CAM 中存在同名用户时的处理策略。取值： KeepBoth：两者都保留。当CIC 用户被同步到 CAM 时，如果 CAM 已经存在同名用户，则对CIC 用户的用户名添加后缀_cic后尝试创建该用户名的 CAM 用户。 TakeOver：替换。当CIC 用户被同步到 CAM 时，如果 CAM 已经存在同名用户，则直接将已经存在的 CAM 用户替换为CIC 同步用户。
        /// </summary>
        [JsonProperty("DuplicationStrategy")]
        public string DuplicationStrategy{ get; set; }

        /// <summary>
        /// 删除策略。删除 CAM 用户同步时，对已同步的 CAM 用户的处理策略。取值： Delete：删除。删除 CAM 用户同步时，会删除从CIC 已经同步到 CAM 中的 CAM 用户。 Keep：保留。删除 RAM 用户同步时，会保留从CIC 已经同步到 CAM 中的 CAM 用户。
        /// </summary>
        [JsonProperty("DeletionStrategy")]
        public string DeletionStrategy{ get; set; }

        /// <summary>
        /// 同步的集团账号目标账号的类型，ManagerUin管理账号;MemberUin成员账号
        /// </summary>
        [JsonProperty("TargetType")]
        public string TargetType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "PrincipalId", this.PrincipalId);
            this.SetParamSimple(map, prefix + "PrincipalType", this.PrincipalType);
            this.SetParamSimple(map, prefix + "TargetUin", this.TargetUin);
            this.SetParamSimple(map, prefix + "DuplicationStrategy", this.DuplicationStrategy);
            this.SetParamSimple(map, prefix + "DeletionStrategy", this.DeletionStrategy);
            this.SetParamSimple(map, prefix + "TargetType", this.TargetType);
        }
    }
}

