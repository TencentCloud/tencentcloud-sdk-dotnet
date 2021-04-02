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

    public class GetDetectInfoEnhancedRequest : AbstractModel
    {
        
        /// <summary>
        /// 人脸核身流程的标识，调用DetectAuth接口时生成。
        /// </summary>
        [JsonProperty("BizToken")]
        public string BizToken{ get; set; }

        /// <summary>
        /// 用于细分客户使用场景，由腾讯侧在线下对接时分配。
        /// </summary>
        [JsonProperty("RuleId")]
        public string RuleId{ get; set; }

        /// <summary>
        /// 指定拉取的结果信息，取值（0：全部；1：文本类；2：身份证信息；3：视频最佳截图信息）。
        /// 如 13表示拉取文本类、视频最佳截图信息。
        /// 默认值：0
        /// </summary>
        [JsonProperty("InfoType")]
        public string InfoType{ get; set; }

        /// <summary>
        /// 从活体视频中截取一定张数的最佳帧（仅部分服务支持，若需使用请与慧眼小助手沟通）。默认为0，最大为10，超出10的最多只给10张。（InfoType需要包含3）
        /// </summary>
        [JsonProperty("BestFramesCount")]
        public ulong? BestFramesCount{ get; set; }

        /// <summary>
        /// 是否对身份证照片进行裁边。默认为false。（InfoType需要包含2）
        /// </summary>
        [JsonProperty("IsCutIdCardImage")]
        public bool? IsCutIdCardImage{ get; set; }

        /// <summary>
        /// 是否需要从身份证中抠出头像。默认为false。（InfoType需要包含2）
        /// </summary>
        [JsonProperty("IsNeedIdCardAvatar")]
        public bool? IsNeedIdCardAvatar{ get; set; }

        /// <summary>
        /// 是否需要对返回中的敏感信息进行加密。其中敏感信息包括：Response.Text.IdCard、Response.Text.Name、Response.Text.OcrIdCard、Response.Text.OcrName
        /// </summary>
        [JsonProperty("IsEncrypt")]
        public bool? IsEncrypt{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BizToken", this.BizToken);
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamSimple(map, prefix + "InfoType", this.InfoType);
            this.SetParamSimple(map, prefix + "BestFramesCount", this.BestFramesCount);
            this.SetParamSimple(map, prefix + "IsCutIdCardImage", this.IsCutIdCardImage);
            this.SetParamSimple(map, prefix + "IsNeedIdCardAvatar", this.IsNeedIdCardAvatar);
            this.SetParamSimple(map, prefix + "IsEncrypt", this.IsEncrypt);
        }
    }
}

