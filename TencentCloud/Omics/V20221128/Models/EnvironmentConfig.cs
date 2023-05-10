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

namespace TencentCloud.Omics.V20221128.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EnvironmentConfig : AbstractModel
    {
        
        /// <summary>
        /// 私有网络配置。
        /// </summary>
        [JsonProperty("VPCOption")]
        public VPCOption VPCOption{ get; set; }

        /// <summary>
        /// 计算集群配置。
        /// </summary>
        [JsonProperty("ClusterOption")]
        public ClusterOption ClusterOption{ get; set; }

        /// <summary>
        /// 数据库配置。
        /// </summary>
        [JsonProperty("DatabaseOption")]
        public DatabaseOption DatabaseOption{ get; set; }

        /// <summary>
        /// 存储配置。
        /// </summary>
        [JsonProperty("StorageOption")]
        public StorageOption StorageOption{ get; set; }

        /// <summary>
        /// 云服务器配置。
        /// </summary>
        [JsonProperty("CVMOption")]
        public CVMOption CVMOption{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "VPCOption.", this.VPCOption);
            this.SetParamObj(map, prefix + "ClusterOption.", this.ClusterOption);
            this.SetParamObj(map, prefix + "DatabaseOption.", this.DatabaseOption);
            this.SetParamObj(map, prefix + "StorageOption.", this.StorageOption);
            this.SetParamObj(map, prefix + "CVMOption.", this.CVMOption);
        }
    }
}

