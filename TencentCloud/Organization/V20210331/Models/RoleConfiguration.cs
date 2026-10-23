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

    public class RoleConfiguration : AbstractModel
    {
        
        /// <summary>
        /// <p>权限配置配置ID。</p>
        /// </summary>
        [JsonProperty("RoleConfigurationId")]
        public string RoleConfigurationId{ get; set; }

        /// <summary>
        /// <p>权限配置配名称。</p>
        /// </summary>
        [JsonProperty("RoleConfigurationName")]
        public string RoleConfigurationName{ get; set; }

        /// <summary>
        /// <p>权限配置的描述。</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>会话持续时间。CIC 用户使用访问配置访问成员账号时，会话最多保持的时间。<br>单位：秒。</p>
        /// </summary>
        [JsonProperty("SessionDuration")]
        public long? SessionDuration{ get; set; }

        /// <summary>
        /// <p>初始访问页面。CIC 用户使用访问配置访问成员账号时，初始访问的页面地址。</p>
        /// </summary>
        [JsonProperty("RelayState")]
        public string RelayState{ get; set; }

        /// <summary>
        /// <p>权限配置的创建时间。</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>权限配置的更新时间。</p>
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// <p>如果有入参FilterTargets查询成员账号是否配置过权限，配置了返回true，否则返回false。</p>
        /// </summary>
        [JsonProperty("IsSelected")]
        public bool? IsSelected{ get; set; }

        /// <summary>
        /// <p>会话时长应用状态</p><p>枚举值：</p><ul><li>Success： 全部账号应用成功</li><li>Failed： 存在失败账号</li><li>Applying： 任务在途</li><li>Unknown： 已部署账号超查询上限</li></ul>
        /// </summary>
        [JsonProperty("ApplyStatus")]
        public string ApplyStatus{ get; set; }

        /// <summary>
        /// <p>当前已真实下发到 CAM 的会话时长</p><p>取值范围：[900, 43200]</p><p>单位：秒</p>
        /// </summary>
        [JsonProperty("AppliedSessionDuration")]
        public ulong? AppliedSessionDuration{ get; set; }

        /// <summary>
        /// <p>最近一次成功下发时间</p><p>参数格式： YYYY-MM-DD hh:mm:ss</p>
        /// </summary>
        [JsonProperty("SessionDurationUpdateTime")]
        public string SessionDurationUpdateTime{ get; set; }

        /// <summary>
        /// <p>未成功应用的账号明细</p><p>仅 Failed 态返回</p>
        /// </summary>
        [JsonProperty("FailedAccounts")]
        public FailedAccount[] FailedAccounts{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RoleConfigurationId", this.RoleConfigurationId);
            this.SetParamSimple(map, prefix + "RoleConfigurationName", this.RoleConfigurationName);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "SessionDuration", this.SessionDuration);
            this.SetParamSimple(map, prefix + "RelayState", this.RelayState);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "IsSelected", this.IsSelected);
            this.SetParamSimple(map, prefix + "ApplyStatus", this.ApplyStatus);
            this.SetParamSimple(map, prefix + "AppliedSessionDuration", this.AppliedSessionDuration);
            this.SetParamSimple(map, prefix + "SessionDurationUpdateTime", this.SessionDurationUpdateTime);
            this.SetParamArrayObj(map, prefix + "FailedAccounts.", this.FailedAccounts);
        }
    }
}

