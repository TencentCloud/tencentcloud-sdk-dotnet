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

namespace TencentCloud.Redis.V20180412.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InstanceClusterNode : AbstractModel
    {
        
        /// <summary>
        /// 节点名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 实例运行时节点Id
        /// </summary>
        [JsonProperty("RunId")]
        public string RunId{ get; set; }

        /// <summary>
        /// 集群角色：0-master；1-slave
        /// </summary>
        [JsonProperty("Role")]
        public long? Role{ get; set; }

        /// <summary>
        /// 节点状态：0-readwrite, 1-read, 2-backup
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 服务状态：0-down；1-on
        /// </summary>
        [JsonProperty("Connected")]
        public long? Connected{ get; set; }

        /// <summary>
        /// 节点创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 节点下线时间
        /// </summary>
        [JsonProperty("DownTime")]
        public string DownTime{ get; set; }

        /// <summary>
        /// 节点slot分布
        /// </summary>
        [JsonProperty("Slots")]
        public string Slots{ get; set; }

        /// <summary>
        /// 节点key分布
        /// </summary>
        [JsonProperty("Keys")]
        public long? Keys{ get; set; }

        /// <summary>
        /// 节点qps
        /// </summary>
        [JsonProperty("Qps")]
        public long? Qps{ get; set; }

        /// <summary>
        /// 节点qps倾斜度
        /// </summary>
        [JsonProperty("QpsSlope")]
        public float? QpsSlope{ get; set; }

        /// <summary>
        /// 节点存储
        /// </summary>
        [JsonProperty("Storage")]
        public long? Storage{ get; set; }

        /// <summary>
        /// 节点存储倾斜度
        /// </summary>
        [JsonProperty("StorageSlope")]
        public float? StorageSlope{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "RunId", this.RunId);
            this.SetParamSimple(map, prefix + "Role", this.Role);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Connected", this.Connected);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "DownTime", this.DownTime);
            this.SetParamSimple(map, prefix + "Slots", this.Slots);
            this.SetParamSimple(map, prefix + "Keys", this.Keys);
            this.SetParamSimple(map, prefix + "Qps", this.Qps);
            this.SetParamSimple(map, prefix + "QpsSlope", this.QpsSlope);
            this.SetParamSimple(map, prefix + "Storage", this.Storage);
            this.SetParamSimple(map, prefix + "StorageSlope", this.StorageSlope);
        }
    }
}

