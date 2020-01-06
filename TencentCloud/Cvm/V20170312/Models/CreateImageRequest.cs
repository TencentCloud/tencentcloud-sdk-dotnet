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

namespace TencentCloud.Cvm.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateImageRequest : AbstractModel
    {
        
        /// <summary>
        /// 镜像名称
        /// </summary>
        [JsonProperty("ImageName")]
        public string ImageName{ get; set; }

        /// <summary>
        /// 需要制作镜像的实例ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 镜像描述
        /// </summary>
        [JsonProperty("ImageDescription")]
        public string ImageDescription{ get; set; }

        /// <summary>
        /// 是否执行强制关机以制作镜像。
        /// 取值范围：<br><li>TRUE：表示关机之后制作镜像<br><li>FALSE：表示开机状态制作镜像<br><br>默认取值：FALSE。<br><br>开机状态制作镜像，可能导致部分数据未备份，影响数据安全。
        /// </summary>
        [JsonProperty("ForcePoweroff")]
        public string ForcePoweroff{ get; set; }

        /// <summary>
        /// 创建Windows镜像时是否启用Sysprep
        /// </summary>
        [JsonProperty("Sysprep")]
        public string Sysprep{ get; set; }

        /// <summary>
        /// 实例需要制作镜像的数据盘Id
        /// </summary>
        [JsonProperty("DataDiskIds")]
        public string[] DataDiskIds{ get; set; }

        /// <summary>
        /// 需要制作镜像的快照ID,必须包含一个系统盘快照
        /// </summary>
        [JsonProperty("SnapshotIds")]
        public string[] SnapshotIds{ get; set; }

        /// <summary>
        /// 检测请求的合法性，但不会对操作的资源产生任何影响
        /// </summary>
        [JsonProperty("DryRun")]
        public bool? DryRun{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ImageName", this.ImageName);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "ImageDescription", this.ImageDescription);
            this.SetParamSimple(map, prefix + "ForcePoweroff", this.ForcePoweroff);
            this.SetParamSimple(map, prefix + "Sysprep", this.Sysprep);
            this.SetParamArraySimple(map, prefix + "DataDiskIds.", this.DataDiskIds);
            this.SetParamArraySimple(map, prefix + "SnapshotIds.", this.SnapshotIds);
            this.SetParamSimple(map, prefix + "DryRun", this.DryRun);
        }
    }
}

