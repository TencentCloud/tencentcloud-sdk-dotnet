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

namespace TencentCloud.Gs.V20191118.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AndroidInstance : AbstractModel
    {
        
        /// <summary>
        /// <p>实例 ID</p>
        /// </summary>
        [JsonProperty("AndroidInstanceId")]
        public string AndroidInstanceId{ get; set; }

        /// <summary>
        /// <p>实例所在区域</p>
        /// </summary>
        [JsonProperty("AndroidInstanceRegion")]
        public string AndroidInstanceRegion{ get; set; }

        /// <summary>
        /// <p>实例可用区</p>
        /// </summary>
        [JsonProperty("AndroidInstanceZone")]
        public string AndroidInstanceZone{ get; set; }

        /// <summary>
        /// <p>实例状态：INITIALIZING，NORMAL，PROCESSING</p>
        /// </summary>
        [JsonProperty("State")]
        public string State{ get; set; }

        /// <summary>
        /// <p>实例规格</p>
        /// </summary>
        [JsonProperty("AndroidInstanceType")]
        public string AndroidInstanceType{ get; set; }

        /// <summary>
        /// <p>实例镜像 ID</p>
        /// </summary>
        [JsonProperty("AndroidInstanceImageId")]
        public string AndroidInstanceImageId{ get; set; }

        /// <summary>
        /// <p>分辨率宽度</p>
        /// </summary>
        [JsonProperty("Width")]
        public ulong? Width{ get; set; }

        /// <summary>
        /// <p>分辨率高度</p>
        /// </summary>
        [JsonProperty("Height")]
        public ulong? Height{ get; set; }

        /// <summary>
        /// <p>每英寸像素点。</p>
        /// </summary>
        [JsonProperty("DPI")]
        public ulong? DPI{ get; set; }

        /// <summary>
        /// <p>帧率</p>
        /// </summary>
        [JsonProperty("FPS")]
        public ulong? FPS{ get; set; }

        /// <summary>
        /// <p>宿主机 ID</p>
        /// </summary>
        [JsonProperty("HostSerialNumber")]
        public string HostSerialNumber{ get; set; }

        /// <summary>
        /// <p>分组 ID</p>
        /// </summary>
        [JsonProperty("AndroidInstanceGroupId")]
        public string AndroidInstanceGroupId{ get; set; }

        /// <summary>
        /// <p>标签列表</p>
        /// </summary>
        [JsonProperty("AndroidInstanceLabels")]
        public AndroidInstanceLabel[] AndroidInstanceLabels{ get; set; }

        /// <summary>
        /// <p>名称</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>用户ID</p>
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// <p>内网 IP</p>
        /// </summary>
        [JsonProperty("PrivateIP")]
        public string PrivateIP{ get; set; }

        /// <summary>
        /// <p>创建时间</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>机箱 ID</p>
        /// </summary>
        [JsonProperty("HostServerSerialNumber")]
        public string HostServerSerialNumber{ get; set; }

        /// <summary>
        /// <p>服务状态。<br>IDLE：未连接<br>ESTABLISHED：连接中</p>
        /// </summary>
        [JsonProperty("ServiceStatus")]
        public string ServiceStatus{ get; set; }

        /// <summary>
        /// <p>安卓实例型号。<br>YS1：默认值，基础型云手机<br>GC0、GC1、GC2：三种性能型云手机</p>
        /// </summary>
        [JsonProperty("AndroidInstanceModel")]
        public string AndroidInstanceModel{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AndroidInstanceId", this.AndroidInstanceId);
            this.SetParamSimple(map, prefix + "AndroidInstanceRegion", this.AndroidInstanceRegion);
            this.SetParamSimple(map, prefix + "AndroidInstanceZone", this.AndroidInstanceZone);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "AndroidInstanceType", this.AndroidInstanceType);
            this.SetParamSimple(map, prefix + "AndroidInstanceImageId", this.AndroidInstanceImageId);
            this.SetParamSimple(map, prefix + "Width", this.Width);
            this.SetParamSimple(map, prefix + "Height", this.Height);
            this.SetParamSimple(map, prefix + "DPI", this.DPI);
            this.SetParamSimple(map, prefix + "FPS", this.FPS);
            this.SetParamSimple(map, prefix + "HostSerialNumber", this.HostSerialNumber);
            this.SetParamSimple(map, prefix + "AndroidInstanceGroupId", this.AndroidInstanceGroupId);
            this.SetParamArrayObj(map, prefix + "AndroidInstanceLabels.", this.AndroidInstanceLabels);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "PrivateIP", this.PrivateIP);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "HostServerSerialNumber", this.HostServerSerialNumber);
            this.SetParamSimple(map, prefix + "ServiceStatus", this.ServiceStatus);
            this.SetParamSimple(map, prefix + "AndroidInstanceModel", this.AndroidInstanceModel);
        }
    }
}

