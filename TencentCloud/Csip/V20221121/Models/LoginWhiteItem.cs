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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LoginWhiteItem : AbstractModel
    {
        
        /// <summary>
        /// <p>白名单类型：Custom-自定义白名单 Learn-自学习白名单</p>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>规则所属账号 AppId，多账号场景下用于区分与后续编辑定位</p>
        /// </summary>
        [JsonProperty("AppId")]
        public ulong? AppId{ get; set; }

        /// <summary>
        /// <p>规则ID；自学习为规则组ID（组内最小行ID）</p>
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }

        /// <summary>
        /// <p>登录源IP（逗号分隔）；自学习白名单恒为空</p>
        /// </summary>
        [JsonProperty("SrcIp")]
        public string SrcIp{ get; set; }

        /// <summary>
        /// <p>登录用户名（逗号分隔）；自学习白名单恒为空</p>
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// <p>登录时段起始 HH:MM；自学习白名单恒为空</p>
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// <p>登录时段结束 HH:MM；自学习白名单恒为空</p>
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// <p>常用登录地列表</p>
        /// </summary>
        [JsonProperty("Places")]
        public LoginWhitePlace[] Places{ get; set; }

        /// <summary>
        /// <p>常用登录地展示文案（逗号分隔），供列表直接展示</p>
        /// </summary>
        [JsonProperty("Locations")]
        public string Locations{ get; set; }

        /// <summary>
        /// <p>生效资产范围：0-指定主机（主机或标签命中） 1-全部主机</p>
        /// </summary>
        [JsonProperty("Scope")]
        public long? Scope{ get; set; }

        /// <summary>
        /// <p>生效主机 QUUID 列表（与 InstanceIDs 一一对应）</p>
        /// </summary>
        [JsonProperty("QUUIDS")]
        public string[] QUUIDS{ get; set; }

        /// <summary>
        /// <p>生效主机实例ID列表（与 QUUIDS 一一对应）</p>
        /// </summary>
        [JsonProperty("InstanceIDs")]
        public string[] InstanceIDs{ get; set; }

        /// <summary>
        /// <p>剔除主机 QUUID 列表</p>
        /// </summary>
        [JsonProperty("ExcludeQUUIDS")]
        public string[] ExcludeQUUIDS{ get; set; }

        /// <summary>
        /// <p>剔除主机实例ID列表</p>
        /// </summary>
        [JsonProperty("ExcludeInstanceIDs")]
        public string[] ExcludeInstanceIDs{ get; set; }

        /// <summary>
        /// <p>生效标签详情列表</p>
        /// </summary>
        [JsonProperty("TagItems")]
        public EDRRuleTagItem[] TagItems{ get; set; }

        /// <summary>
        /// <p>主机数：自定义为指定主机数（Scope=1 时为 0，前端展示全部主机）；自学习为组内去重主机数</p>
        /// </summary>
        [JsonProperty("HostCount")]
        public long? HostCount{ get; set; }

        /// <summary>
        /// <p>备注</p>
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// <p>创建时间，格式 2006-01-02 15:04:05</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>最近修改时间，格式 2006-01-02 15:04:05</p>
        /// </summary>
        [JsonProperty("ModifyTime")]
        public string ModifyTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "SrcIp", this.SrcIp);
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamArrayObj(map, prefix + "Places.", this.Places);
            this.SetParamSimple(map, prefix + "Locations", this.Locations);
            this.SetParamSimple(map, prefix + "Scope", this.Scope);
            this.SetParamArraySimple(map, prefix + "QUUIDS.", this.QUUIDS);
            this.SetParamArraySimple(map, prefix + "InstanceIDs.", this.InstanceIDs);
            this.SetParamArraySimple(map, prefix + "ExcludeQUUIDS.", this.ExcludeQUUIDS);
            this.SetParamArraySimple(map, prefix + "ExcludeInstanceIDs.", this.ExcludeInstanceIDs);
            this.SetParamArrayObj(map, prefix + "TagItems.", this.TagItems);
            this.SetParamSimple(map, prefix + "HostCount", this.HostCount);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "ModifyTime", this.ModifyTime);
        }
    }
}

