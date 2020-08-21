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

namespace TencentCloud.Ecm.V20190719.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Module : AbstractModel
    {
        
        /// <summary>
        /// 模块Id
        /// </summary>
        [JsonProperty("ModuleId")]
        public string ModuleId{ get; set; }

        /// <summary>
        /// 模块名称
        /// </summary>
        [JsonProperty("ModuleName")]
        public string ModuleName{ get; set; }

        /// <summary>
        /// 模块状态：
        /// NORMAL：正常
        /// DELETING：删除中 
        /// DELETEFAILED：删除失败
        /// </summary>
        [JsonProperty("ModuleState")]
        public string ModuleState{ get; set; }

        /// <summary>
        /// 默认系统盘大小
        /// </summary>
        [JsonProperty("DefaultSystemDiskSize")]
        public long? DefaultSystemDiskSize{ get; set; }

        /// <summary>
        /// 默认数据盘大小
        /// </summary>
        [JsonProperty("DefaultDataDiskSize")]
        public long? DefaultDataDiskSize{ get; set; }

        /// <summary>
        /// 默认机型
        /// </summary>
        [JsonProperty("InstanceTypeConfig")]
        public InstanceTypeConfig InstanceTypeConfig{ get; set; }

        /// <summary>
        /// 默认镜像
        /// </summary>
        [JsonProperty("DefaultImage")]
        public Image DefaultImage{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 默认带宽
        /// </summary>
        [JsonProperty("DefaultBandwidth")]
        public long? DefaultBandwidth{ get; set; }

        /// <summary>
        /// 标签集合
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TagSet")]
        public Tag[] TagSet{ get; set; }

        /// <summary>
        /// 是否关闭IP直通
        /// </summary>
        [JsonProperty("CloseIpDirect")]
        public long? CloseIpDirect{ get; set; }

        /// <summary>
        /// 默认安全组id列表
        /// </summary>
        [JsonProperty("SecurityGroupIds")]
        public string[] SecurityGroupIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ModuleId", this.ModuleId);
            this.SetParamSimple(map, prefix + "ModuleName", this.ModuleName);
            this.SetParamSimple(map, prefix + "ModuleState", this.ModuleState);
            this.SetParamSimple(map, prefix + "DefaultSystemDiskSize", this.DefaultSystemDiskSize);
            this.SetParamSimple(map, prefix + "DefaultDataDiskSize", this.DefaultDataDiskSize);
            this.SetParamObj(map, prefix + "InstanceTypeConfig.", this.InstanceTypeConfig);
            this.SetParamObj(map, prefix + "DefaultImage.", this.DefaultImage);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "DefaultBandwidth", this.DefaultBandwidth);
            this.SetParamArrayObj(map, prefix + "TagSet.", this.TagSet);
            this.SetParamSimple(map, prefix + "CloseIpDirect", this.CloseIpDirect);
            this.SetParamArraySimple(map, prefix + "SecurityGroupIds.", this.SecurityGroupIds);
        }
    }
}

