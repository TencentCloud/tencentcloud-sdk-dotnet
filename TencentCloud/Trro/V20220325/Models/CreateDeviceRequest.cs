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

namespace TencentCloud.Trro.V20220325.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateDeviceRequest : AbstractModel
    {
        
        /// <summary>
        /// 创建设备所归属的项目ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 创建设备ID，项目内需要唯一，由小写英文字母、数字和下划线构成，长度不超过18
        /// </summary>
        [JsonProperty("DeviceId")]
        public string DeviceId{ get; set; }

        /// <summary>
        /// 创建设备名称，长度小于24, 可包含中文、数字、英文字母和下划线
        /// </summary>
        [JsonProperty("DeviceName")]
        public string DeviceName{ get; set; }

        /// <summary>
        /// 设备类型，field为现场设备（受控设备），remote为远端设备（操控设备），不填默认为field
        /// </summary>
        [JsonProperty("DeviceType")]
        public string DeviceType{ get; set; }

        /// <summary>
        /// 设备认证口令，由大小写英文字母和数字构成，须为16位
        /// </summary>
        [JsonProperty("DeviceToken")]
        public string DeviceToken{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "DeviceId", this.DeviceId);
            this.SetParamSimple(map, prefix + "DeviceName", this.DeviceName);
            this.SetParamSimple(map, prefix + "DeviceType", this.DeviceType);
            this.SetParamSimple(map, prefix + "DeviceToken", this.DeviceToken);
        }
    }
}

