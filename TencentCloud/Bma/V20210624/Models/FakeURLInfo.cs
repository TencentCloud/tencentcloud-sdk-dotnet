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

namespace TencentCloud.Bma.V20210624.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FakeURLInfo : AbstractModel
    {
        
        /// <summary>
        /// 仿冒网址ID
        /// </summary>
        [JsonProperty("FakeURLId")]
        public long? FakeURLId{ get; set; }

        /// <summary>
        /// 保护网站
        /// </summary>
        [JsonProperty("ProtectWeb")]
        public string ProtectWeb{ get; set; }

        /// <summary>
        /// 检测时间
        /// </summary>
        [JsonProperty("DetectTime")]
        public string DetectTime{ get; set; }

        /// <summary>
        /// 仿冒网址
        /// </summary>
        [JsonProperty("FakeURL")]
        public string FakeURL{ get; set; }

        /// <summary>
        /// 截图
        /// </summary>
        [JsonProperty("Snapshot")]
        public string Snapshot{ get; set; }

        /// <summary>
        /// IP地址
        /// </summary>
        [JsonProperty("IP")]
        public string IP{ get; set; }

        /// <summary>
        /// IP地理位置
        /// </summary>
        [JsonProperty("IPLoc")]
        public string IPLoc{ get; set; }

        /// <summary>
        /// 热度
        /// </summary>
        [JsonProperty("Heat")]
        public long? Heat{ get; set; }

        /// <summary>
        /// 网址状态
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("Note")]
        public string Note{ get; set; }

        /// <summary>
        /// 仿冒网站所属单位
        /// </summary>
        [JsonProperty("FakeURLCompany")]
        public string FakeURLCompany{ get; set; }

        /// <summary>
        /// 仿冒网站性质
        /// </summary>
        [JsonProperty("FakeURLAttr")]
        public string FakeURLAttr{ get; set; }

        /// <summary>
        /// 仿冒网站名称
        /// </summary>
        [JsonProperty("FakeURLName")]
        public string FakeURLName{ get; set; }

        /// <summary>
        /// 仿冒网站备案号
        /// </summary>
        [JsonProperty("FakeURLICP")]
        public string FakeURLICP{ get; set; }

        /// <summary>
        /// 仿冒网站创建时间
        /// </summary>
        [JsonProperty("FakeURLCreateTime")]
        public string FakeURLCreateTime{ get; set; }

        /// <summary>
        /// 仿冒网站过期时间
        /// </summary>
        [JsonProperty("FakeURLExpireTime")]
        public string FakeURLExpireTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FakeURLId", this.FakeURLId);
            this.SetParamSimple(map, prefix + "ProtectWeb", this.ProtectWeb);
            this.SetParamSimple(map, prefix + "DetectTime", this.DetectTime);
            this.SetParamSimple(map, prefix + "FakeURL", this.FakeURL);
            this.SetParamSimple(map, prefix + "Snapshot", this.Snapshot);
            this.SetParamSimple(map, prefix + "IP", this.IP);
            this.SetParamSimple(map, prefix + "IPLoc", this.IPLoc);
            this.SetParamSimple(map, prefix + "Heat", this.Heat);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Note", this.Note);
            this.SetParamSimple(map, prefix + "FakeURLCompany", this.FakeURLCompany);
            this.SetParamSimple(map, prefix + "FakeURLAttr", this.FakeURLAttr);
            this.SetParamSimple(map, prefix + "FakeURLName", this.FakeURLName);
            this.SetParamSimple(map, prefix + "FakeURLICP", this.FakeURLICP);
            this.SetParamSimple(map, prefix + "FakeURLCreateTime", this.FakeURLCreateTime);
            this.SetParamSimple(map, prefix + "FakeURLExpireTime", this.FakeURLExpireTime);
        }
    }
}

