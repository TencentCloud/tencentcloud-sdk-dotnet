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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EscapeWhiteListInfo : AbstractModel
    {
        
        /// <summary>
        /// 镜像ID
        /// </summary>
        [JsonProperty("ImageID")]
        public string ImageID{ get; set; }

        /// <summary>
        /// 镜像名称
        /// </summary>
        [JsonProperty("ImageName")]
        public string ImageName{ get; set; }

        /// <summary>
        /// 白名单记录ID
        /// </summary>
        [JsonProperty("ID")]
        public long? ID{ get; set; }

        /// <summary>
        /// 关联主机数量（包含普通节点和超级节点数量）
        /// </summary>
        [JsonProperty("HostCount")]
        public long? HostCount{ get; set; }

        /// <summary>
        /// 关联超级节点数量
        /// </summary>
        [JsonProperty("SuperNodeCount")]
        public long? SuperNodeCount{ get; set; }

        /// <summary>
        /// 关联容器数量
        /// </summary>
        [JsonProperty("ContainerCount")]
        public long? ContainerCount{ get; set; }

        /// <summary>
        /// 加白事件类型
        /// </summary>
        [JsonProperty("EventType")]
        public string[] EventType{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("InsertTime")]
        public string InsertTime{ get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 镜像大小
        /// </summary>
        [JsonProperty("ImageSize")]
        public long? ImageSize{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ImageID", this.ImageID);
            this.SetParamSimple(map, prefix + "ImageName", this.ImageName);
            this.SetParamSimple(map, prefix + "ID", this.ID);
            this.SetParamSimple(map, prefix + "HostCount", this.HostCount);
            this.SetParamSimple(map, prefix + "SuperNodeCount", this.SuperNodeCount);
            this.SetParamSimple(map, prefix + "ContainerCount", this.ContainerCount);
            this.SetParamArraySimple(map, prefix + "EventType.", this.EventType);
            this.SetParamSimple(map, prefix + "InsertTime", this.InsertTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "ImageSize", this.ImageSize);
        }
    }
}

