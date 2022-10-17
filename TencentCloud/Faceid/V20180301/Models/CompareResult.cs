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

    public class CompareResult : AbstractModel
    {
        
        /// <summary>
        /// 最终比对结果
        /// </summary>
        [JsonProperty("ErrorCode")]
        public string ErrorCode{ get; set; }

        /// <summary>
        /// 最终比对结果描述
        /// </summary>
        [JsonProperty("ErrorMsg")]
        public string ErrorMsg{ get; set; }

        /// <summary>
        /// 本次活体SDK生成的活体算法数据包
        /// </summary>
        [JsonProperty("LiveData")]
        public FileInfo LiveData{ get; set; }

        /// <summary>
        /// 本次用户活体验证过程的视频，url链接有效期10分钟。
        /// </summary>
        [JsonProperty("LiveVideo")]
        public FileInfo LiveVideo{ get; set; }

        /// <summary>
        /// 活体认证结果码
        /// </summary>
        [JsonProperty("LiveErrorCode")]
        public string LiveErrorCode{ get; set; }

        /// <summary>
        /// 活体认证结果描述
        /// </summary>
        [JsonProperty("LiveErrorMsg")]
        public string LiveErrorMsg{ get; set; }

        /// <summary>
        /// 本次活体的最佳人像截图，url链接有效期10分钟。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BestFrame")]
        public FileInfo BestFrame{ get; set; }

        /// <summary>
        /// 证件照头像截图，url链接有效期10分钟。
        /// </summary>
        [JsonProperty("ProfileImage")]
        public FileInfo ProfileImage{ get; set; }

        /// <summary>
        /// 人脸比对结果码
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CompareErrorCode")]
        public string CompareErrorCode{ get; set; }

        /// <summary>
        /// 人脸比对结果描述
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CompareErrorMsg")]
        public string CompareErrorMsg{ get; set; }

        /// <summary>
        /// 相似度
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Sim")]
        public float? Sim{ get; set; }

        /// <summary>
        /// 该字段废弃
        /// </summary>
        [JsonProperty("IsNeedCharge")]
        public bool? IsNeedCharge{ get; set; }

        /// <summary>
        /// 用户编辑后的证件照信息，如果DisableChangeOcrResult为true禁用编辑无该值。url链接有效期10分钟。格式为json文本信息。
        /// IdCardType为HK时：
        /// - CnName string 中文姓名
        /// - EnName string 英文姓名
        /// - TelexCode string 中文姓名对应电码
        /// - Sex string 性别 ：“男M”或“女F”
        /// - Birthday string 出生日期
        /// - Permanent int 永久性居民身份证。0：非永久； 1：永久； -1：未知。
        /// - IdNum string 身份证号码
        /// - Symbol string 证件符号，出生日期下的符号，例如"***AZ"
        /// - FirstIssueDate string 首次签发日期
        /// - CurrentIssueDate string 最近领用日期
        /// 
        /// IdCardType为ML时：
        /// - Sex string 男：LELAKI 女：PEREMPUAN
        /// - Birthday  string
        /// - ID string
        /// - Name string
        /// - Address string
        /// - Type string 证件类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CardInfoInputJson")]
        public FileInfo CardInfoInputJson{ get; set; }

        /// <summary>
        /// 本次认证的请求标识。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ErrorCode", this.ErrorCode);
            this.SetParamSimple(map, prefix + "ErrorMsg", this.ErrorMsg);
            this.SetParamObj(map, prefix + "LiveData.", this.LiveData);
            this.SetParamObj(map, prefix + "LiveVideo.", this.LiveVideo);
            this.SetParamSimple(map, prefix + "LiveErrorCode", this.LiveErrorCode);
            this.SetParamSimple(map, prefix + "LiveErrorMsg", this.LiveErrorMsg);
            this.SetParamObj(map, prefix + "BestFrame.", this.BestFrame);
            this.SetParamObj(map, prefix + "ProfileImage.", this.ProfileImage);
            this.SetParamSimple(map, prefix + "CompareErrorCode", this.CompareErrorCode);
            this.SetParamSimple(map, prefix + "CompareErrorMsg", this.CompareErrorMsg);
            this.SetParamSimple(map, prefix + "Sim", this.Sim);
            this.SetParamSimple(map, prefix + "IsNeedCharge", this.IsNeedCharge);
            this.SetParamObj(map, prefix + "CardInfoInputJson.", this.CardInfoInputJson);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

