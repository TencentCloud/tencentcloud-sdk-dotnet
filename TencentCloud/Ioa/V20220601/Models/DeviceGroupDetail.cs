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

namespace TencentCloud.Ioa.V20220601.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeviceGroupDetail : AbstractModel
    {
        
        /// <summary>
        /// 设备组id
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// 设备组名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 设备组描述
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 父节点id
        /// </summary>
        [JsonProperty("ParentId")]
        public long? ParentId{ get; set; }

        /// <summary>
        /// 基于id的节点路径
        /// </summary>
        [JsonProperty("IdPath")]
        public string IdPath{ get; set; }

        /// <summary>
        /// 基于名称的节点路径
        /// </summary>
        [JsonProperty("NamePath")]
        public string NamePath{ get; set; }

        /// <summary>
        /// 分组锁定状态
        /// </summary>
        [JsonProperty("Locked")]
        public long? Locked{ get; set; }

        /// <summary>
        /// 系统类型（0: win，1：linux，2: mac，4：android，5：ios   ）
        /// </summary>
        [JsonProperty("OsType")]
        public long? OsType{ get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        [JsonProperty("Sort")]
        public long? Sort{ get; set; }

        /// <summary>
        /// 是否自动调整
        /// </summary>
        [JsonProperty("FromAuto")]
        public long? FromAuto{ get; set; }

        /// <summary>
        /// 子节点数量
        /// </summary>
        [JsonProperty("Count")]
        public long? Count{ get; set; }

        /// <summary>
        /// 图标
        /// </summary>
        [JsonProperty("Icon")]
        public string Icon{ get; set; }

        /// <summary>
        /// 是否有ip
        /// </summary>
        [JsonProperty("WithIp")]
        public long? WithIp{ get; set; }

        /// <summary>
        /// 是否有组ip
        /// </summary>
        [JsonProperty("HasIp")]
        public bool? HasIp{ get; set; }

        /// <summary>
        /// 是否是叶子节点
        /// </summary>
        [JsonProperty("IsLeaf")]
        public bool? IsLeaf{ get; set; }

        /// <summary>
        /// 是否只读
        /// </summary>
        [JsonProperty("ReadOnly")]
        public bool? ReadOnly{ get; set; }

        /// <summary>
        /// 对应绑定的账号id
        /// </summary>
        [JsonProperty("BindAccount")]
        public long? BindAccount{ get; set; }

        /// <summary>
        /// 绑定账号的用户名
        /// </summary>
        [JsonProperty("BindAccountName")]
        public string BindAccountName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "ParentId", this.ParentId);
            this.SetParamSimple(map, prefix + "IdPath", this.IdPath);
            this.SetParamSimple(map, prefix + "NamePath", this.NamePath);
            this.SetParamSimple(map, prefix + "Locked", this.Locked);
            this.SetParamSimple(map, prefix + "OsType", this.OsType);
            this.SetParamSimple(map, prefix + "Sort", this.Sort);
            this.SetParamSimple(map, prefix + "FromAuto", this.FromAuto);
            this.SetParamSimple(map, prefix + "Count", this.Count);
            this.SetParamSimple(map, prefix + "Icon", this.Icon);
            this.SetParamSimple(map, prefix + "WithIp", this.WithIp);
            this.SetParamSimple(map, prefix + "HasIp", this.HasIp);
            this.SetParamSimple(map, prefix + "IsLeaf", this.IsLeaf);
            this.SetParamSimple(map, prefix + "ReadOnly", this.ReadOnly);
            this.SetParamSimple(map, prefix + "BindAccount", this.BindAccount);
            this.SetParamSimple(map, prefix + "BindAccountName", this.BindAccountName);
        }
    }
}

