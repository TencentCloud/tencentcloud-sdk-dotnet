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

namespace TencentCloud.Tcb.V20180608.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EnvInfo : AbstractModel
    {
        
        /// <summary>
        /// 账户下该环境唯一标识
        /// </summary>
        [JsonProperty("EnvId")]
        public string EnvId{ get; set; }

        /// <summary>
        /// 环境来源。包含以下取值：
        /// <li>miniapp：微信小程序</li>
        /// <li>qcloud ：腾讯云</li>
        /// </summary>
        [JsonProperty("Source")]
        public string Source{ get; set; }

        /// <summary>
        /// 环境别名，要以a-z开头，不能包含 a-zA-z0-9- 以外的字符
        /// </summary>
        [JsonProperty("Alias")]
        public string Alias{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 最后修改时间
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 环境状态。包含以下取值：
        /// <li>NORMAL：正常可用</li>
        /// <li>HALTED：停服，用量超限或后台封禁</li>
        /// <li>UNAVAILABLE：服务不可用，可能是尚未初始化或者初始化过程中</li>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 数据库列表
        /// </summary>
        [JsonProperty("Databases")]
        public DatabasesInfo[] Databases{ get; set; }

        /// <summary>
        /// 存储列表
        /// </summary>
        [JsonProperty("Storages")]
        public StorageInfo[] Storages{ get; set; }

        /// <summary>
        /// 函数列表
        /// </summary>
        [JsonProperty("Functions")]
        public FunctionInfo[] Functions{ get; set; }

        /// <summary>
        /// tcb产品套餐ID，参考DescribePackages接口的返回值。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PackageId")]
        public string PackageId{ get; set; }

        /// <summary>
        /// 套餐中文名称，参考DescribePackages接口的返回值。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PackageName")]
        public string PackageName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EnvId", this.EnvId);
            this.SetParamSimple(map, prefix + "Source", this.Source);
            this.SetParamSimple(map, prefix + "Alias", this.Alias);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArrayObj(map, prefix + "Databases.", this.Databases);
            this.SetParamArrayObj(map, prefix + "Storages.", this.Storages);
            this.SetParamArrayObj(map, prefix + "Functions.", this.Functions);
            this.SetParamSimple(map, prefix + "PackageId", this.PackageId);
            this.SetParamSimple(map, prefix + "PackageName", this.PackageName);
        }
    }
}

