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

namespace TencentCloud.Gs.V20191118.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AndroidInstance : AbstractModel
    {
        
        /// <summary>
        /// 实例 ID
        /// </summary>
        [JsonProperty("AndroidInstanceId")]
        public string AndroidInstanceId{ get; set; }

        /// <summary>
        /// 实例所在区域
        /// </summary>
        [JsonProperty("AndroidInstanceRegion")]
        public string AndroidInstanceRegion{ get; set; }

        /// <summary>
        /// 实例可用区
        /// </summary>
        [JsonProperty("AndroidInstanceZone")]
        public string AndroidInstanceZone{ get; set; }

        /// <summary>
        /// 实例状态：INITIALIZING，NORMAL，PROCESSING
        /// </summary>
        [JsonProperty("State")]
        public string State{ get; set; }

        /// <summary>
        /// 实例规格
        /// </summary>
        [JsonProperty("AndroidInstanceType")]
        public string AndroidInstanceType{ get; set; }

        /// <summary>
        /// 实例镜像 ID
        /// </summary>
        [JsonProperty("AndroidInstanceImageId")]
        public string AndroidInstanceImageId{ get; set; }

        /// <summary>
        /// 分辨率宽度
        /// </summary>
        [JsonProperty("Width")]
        public ulong? Width{ get; set; }

        /// <summary>
        /// 分辨率高度
        /// </summary>
        [JsonProperty("Height")]
        public ulong? Height{ get; set; }

        /// <summary>
        /// 宿主机 ID
        /// </summary>
        [JsonProperty("HostSerialNumber")]
        public string HostSerialNumber{ get; set; }

        /// <summary>
        /// 分组 ID
        /// </summary>
        [JsonProperty("AndroidInstanceGroupId")]
        public string AndroidInstanceGroupId{ get; set; }

        /// <summary>
        /// 标签列表
        /// </summary>
        [JsonProperty("AndroidInstanceLabels")]
        public AndroidInstanceLabel[] AndroidInstanceLabels{ get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }


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
            this.SetParamSimple(map, prefix + "HostSerialNumber", this.HostSerialNumber);
            this.SetParamSimple(map, prefix + "AndroidInstanceGroupId", this.AndroidInstanceGroupId);
            this.SetParamArrayObj(map, prefix + "AndroidInstanceLabels.", this.AndroidInstanceLabels);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
        }
    }
}

