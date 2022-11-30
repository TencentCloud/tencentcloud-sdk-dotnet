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
        /// 需要制作镜像的实例ID。基于实例创建镜像时，为必填参数。
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
        /// 创建Windows镜像时是否启用Sysprep。
        /// 取值范围：TRUE或FALSE，默认取值为FALSE。
        /// 
        /// 关于Sysprep的详情请参考[链接](https://cloud.tencent.com/document/product/213/43498)。
        /// </summary>
        [JsonProperty("Sysprep")]
        public string Sysprep{ get; set; }

        /// <summary>
        /// 基于实例创建整机镜像时，指定包含在镜像里的数据盘ID
        /// </summary>
        [JsonProperty("DataDiskIds")]
        public string[] DataDiskIds{ get; set; }

        /// <summary>
        /// 基于快照创建镜像，指定快照ID，必须包含一个系统盘快照。不可与InstanceId同时传入。
        /// </summary>
        [JsonProperty("SnapshotIds")]
        public string[] SnapshotIds{ get; set; }

        /// <summary>
        /// 检测本次请求的是否成功，但不会对操作的资源产生任何影响
        /// </summary>
        [JsonProperty("DryRun")]
        public bool? DryRun{ get; set; }

        /// <summary>
        /// 标签描述列表。通过指定该参数可以同时绑定标签到自定义镜像。
        /// </summary>
        [JsonProperty("TagSpecification")]
        public TagSpecification[] TagSpecification{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ImageName", this.ImageName);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "ImageDescription", this.ImageDescription);
            this.SetParamSimple(map, prefix + "ForcePoweroff", this.ForcePoweroff);
            this.SetParamSimple(map, prefix + "Sysprep", this.Sysprep);
            this.SetParamArraySimple(map, prefix + "DataDiskIds.", this.DataDiskIds);
            this.SetParamArraySimple(map, prefix + "SnapshotIds.", this.SnapshotIds);
            this.SetParamSimple(map, prefix + "DryRun", this.DryRun);
            this.SetParamArrayObj(map, prefix + "TagSpecification.", this.TagSpecification);
        }
    }
}

