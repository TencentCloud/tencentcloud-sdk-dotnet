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

    public class ModifyModuleConfigRequest : AbstractModel
    {
        
        /// <summary>
        /// 模块ID。
        /// </summary>
        [JsonProperty("ModuleId")]
        public string ModuleId{ get; set; }

        /// <summary>
        /// 机型ID。
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// 默认数据盘大小，单位：G。范围不得超过数据盘范围大小，详看DescribeConfig。
        /// </summary>
        [JsonProperty("DefaultDataDiskSize")]
        public long? DefaultDataDiskSize{ get; set; }

        /// <summary>
        /// 默认系统盘大小，单位：G。范围不得超过数据盘范围大小，详看DescribeConfig。
        /// </summary>
        [JsonProperty("DefaultSystemDiskSize")]
        public long? DefaultSystemDiskSize{ get; set; }

        /// <summary>
        /// 系统盘
        /// </summary>
        [JsonProperty("SystemDisk")]
        public SystemDisk SystemDisk{ get; set; }

        /// <summary>
        /// 数据盘
        /// </summary>
        [JsonProperty("DataDisks")]
        public DataDisk[] DataDisks{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ModuleId", this.ModuleId);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "DefaultDataDiskSize", this.DefaultDataDiskSize);
            this.SetParamSimple(map, prefix + "DefaultSystemDiskSize", this.DefaultSystemDiskSize);
            this.SetParamObj(map, prefix + "SystemDisk.", this.SystemDisk);
            this.SetParamArrayObj(map, prefix + "DataDisks.", this.DataDisks);
        }
    }
}

