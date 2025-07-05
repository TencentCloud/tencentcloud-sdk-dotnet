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

namespace TencentCloud.Iotcloud.V20180614.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CLSLogItem : AbstractModel
    {
        
        /// <summary>
        /// 日志内容
        /// </summary>
        [JsonProperty("Content")]
        public string Content{ get; set; }

        /// <summary>
        /// 设备名称
        /// </summary>
        [JsonProperty("Devicename")]
        public string Devicename{ get; set; }

        /// <summary>
        /// 产品ID
        /// </summary>
        [JsonProperty("Productid")]
        public string Productid{ get; set; }

        /// <summary>
        /// 请求ID
        /// </summary>
        [JsonProperty("Requestid")]
        public string Requestid{ get; set; }

        /// <summary>
        /// 结果
        /// </summary>
        [JsonProperty("Result")]
        public string Result{ get; set; }

        /// <summary>
        /// 模块
        /// </summary>
        [JsonProperty("Scene")]
        public string Scene{ get; set; }

        /// <summary>
        /// 日志时间
        /// </summary>
        [JsonProperty("Time")]
        public string Time{ get; set; }

        /// <summary>
        /// 腾讯云账号
        /// </summary>
        [JsonProperty("Userid")]
        public string Userid{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Content", this.Content);
            this.SetParamSimple(map, prefix + "Devicename", this.Devicename);
            this.SetParamSimple(map, prefix + "Productid", this.Productid);
            this.SetParamSimple(map, prefix + "Requestid", this.Requestid);
            this.SetParamSimple(map, prefix + "Result", this.Result);
            this.SetParamSimple(map, prefix + "Scene", this.Scene);
            this.SetParamSimple(map, prefix + "Time", this.Time);
            this.SetParamSimple(map, prefix + "Userid", this.Userid);
        }
    }
}

