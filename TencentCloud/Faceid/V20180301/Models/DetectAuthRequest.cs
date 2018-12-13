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

namespace TencentCloud.Faceid.V20180301.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DetectAuthRequest : AbstractModel
    {
        
        /// <summary>
        /// 规则Id。a-zA-Z0-9组合。最长长度32位。
        /// </summary>
        [JsonProperty("RuleId")]
        public string RuleId{ get; set; }

        /// <summary>
        /// 终端类型。可选值有：weixinh5, weixinh5native, h5, tinyappsdk, iossdk, androidsdk。只有值为"weixinh5"时会返回跳转URL。
        /// </summary>
        [JsonProperty("TerminalType")]
        public string TerminalType{ get; set; }

        /// <summary>
        /// 身份证号或者是客户系统内部的唯一用户id。（传uid的时候只能使用ImageBase64传的照片进行一比一）a-zA-Z0-9组合。最长长度32位。
        /// </summary>
        [JsonProperty("IdCard")]
        public string IdCard{ get; set; }

        /// <summary>
        /// 姓名。最长长度32位。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 回调地址。最长长度1024位。
        /// </summary>
        [JsonProperty("RedirectUrl")]
        public string RedirectUrl{ get; set; }

        /// <summary>
        /// 额外参数，会在getDetectInfo时带回去。最长长度1024位。
        /// </summary>
        [JsonProperty("Extra")]
        public string Extra{ get; set; }

        /// <summary>
        /// 用于一比一时的照片base64。此时必须传入IdCard。
        /// </summary>
        [JsonProperty("ImageBase64")]
        public string ImageBase64{ get; set; }


        /// <summary>
        /// 内部实现，用户禁止调用
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamSimple(map, prefix + "TerminalType", this.TerminalType);
            this.SetParamSimple(map, prefix + "IdCard", this.IdCard);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "RedirectUrl", this.RedirectUrl);
            this.SetParamSimple(map, prefix + "Extra", this.Extra);
            this.SetParamSimple(map, prefix + "ImageBase64", this.ImageBase64);
        }
    }
}

