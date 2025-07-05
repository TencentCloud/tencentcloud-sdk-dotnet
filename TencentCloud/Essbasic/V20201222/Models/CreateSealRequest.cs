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

namespace TencentCloud.Essbasic.V20201222.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateSealRequest : AbstractModel
    {
        
        /// <summary>
        /// 调用方信息
        /// </summary>
        [JsonProperty("Caller")]
        public Caller Caller{ get; set; }

        /// <summary>
        /// 印章类型：
        /// 1. PERSONAL - 个人私章
        /// 2. OFFICIAL - 公章
        /// 3. SPECIAL_FINANCIAL - 财务专用章
        /// 4. CONTRACT - 合同专用章
        /// 5. LEGAL_REPRESENTATIVE - 法定代表人章
        /// 6. SPECIAL_NATIONWIDE_INVOICE - 发票专用章
        /// 7. OTHER-其他
        /// </summary>
        [JsonProperty("SealType")]
        public string SealType{ get; set; }

        /// <summary>
        /// 印章名称
        /// </summary>
        [JsonProperty("SealName")]
        public string SealName{ get; set; }

        /// <summary>
        /// 请求创建印章的客户端IP
        /// </summary>
        [JsonProperty("SourceIp")]
        public string SourceIp{ get; set; }

        /// <summary>
        /// 印章图片，base64编码（与FileId参数二选一，同时传入参数时优先使用Image参数）
        /// </summary>
        [JsonProperty("Image")]
        public string Image{ get; set; }

        /// <summary>
        /// 印章文件图片ID（与Image参数二选一，同时传入参数时优先使用Image参数）
        /// </summary>
        [JsonProperty("FileId")]
        public string FileId{ get; set; }

        /// <summary>
        /// 需要创建印章的用户ID
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// 是否是默认印章 true：是，false：否
        /// </summary>
        [JsonProperty("IsDefault")]
        public bool? IsDefault{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Caller.", this.Caller);
            this.SetParamSimple(map, prefix + "SealType", this.SealType);
            this.SetParamSimple(map, prefix + "SealName", this.SealName);
            this.SetParamSimple(map, prefix + "SourceIp", this.SourceIp);
            this.SetParamSimple(map, prefix + "Image", this.Image);
            this.SetParamSimple(map, prefix + "FileId", this.FileId);
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "IsDefault", this.IsDefault);
        }
    }
}

