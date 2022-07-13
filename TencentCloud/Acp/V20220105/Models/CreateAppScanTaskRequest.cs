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

namespace TencentCloud.Acp.V20220105.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateAppScanTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// 任务类型, 0:基础版, 1:专家版, 2:本地化
        /// </summary>
        [JsonProperty("TaskType")]
        public long? TaskType{ get; set; }

        /// <summary>
        /// 任务来源, 0:小程序诊断, 1:预留字段(暂未使用), 2:app诊断(android);
        /// </summary>
        [JsonProperty("Source")]
        public long? Source{ get; set; }

        /// <summary>
        /// 应用平台, 0:android, 1:ios, 2:小程序
        /// </summary>
        [JsonProperty("Platform")]
        public long? Platform{ get; set; }

        /// <summary>
        /// App包名
        /// </summary>
        [JsonProperty("AppPackage")]
        public string AppPackage{ get; set; }

        /// <summary>
        /// App名称
        /// </summary>
        [JsonProperty("AppName")]
        public string AppName{ get; set; }

        /// <summary>
        /// App版本
        /// </summary>
        [JsonProperty("AppVersion")]
        public string AppVersion{ get; set; }

        /// <summary>
        /// 上传的软件文件ID(任务来源为1时必填)
        /// </summary>
        [JsonProperty("FileID")]
        public string FileID{ get; set; }

        /// <summary>
        /// 软件下载链接地址(任务来源为2时必填)
        /// </summary>
        [JsonProperty("AppDownloadUrl")]
        public string AppDownloadUrl{ get; set; }

        /// <summary>
        /// 隐私文本下载地址(任务来源为2时必填)
        /// </summary>
        [JsonProperty("PrivacyTextUrl")]
        public string PrivacyTextUrl{ get; set; }

        /// <summary>
        /// 联系人信息
        /// </summary>
        [JsonProperty("ContactName")]
        public string ContactName{ get; set; }

        /// <summary>
        /// 联系电话
        /// </summary>
        [JsonProperty("TelNumber")]
        public string TelNumber{ get; set; }

        /// <summary>
        /// 公司邮箱
        /// </summary>
        [JsonProperty("Email")]
        public string Email{ get; set; }

        /// <summary>
        /// 公司名称
        /// </summary>
        [JsonProperty("CorpName")]
        public string CorpName{ get; set; }

        /// <summary>
        /// 商务对接人员
        /// </summary>
        [JsonProperty("SalesPerson")]
        public string SalesPerson{ get; set; }

        /// <summary>
        /// 备注信息
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 是否同意隐私条款，0:不同意(默认), 1:同意
        /// </summary>
        [JsonProperty("IsAgreePrivacy")]
        public long? IsAgreePrivacy{ get; set; }

        /// <summary>
        /// 隐私申明文件名称
        /// </summary>
        [JsonProperty("PrivacyTextName")]
        public string PrivacyTextName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskType", this.TaskType);
            this.SetParamSimple(map, prefix + "Source", this.Source);
            this.SetParamSimple(map, prefix + "Platform", this.Platform);
            this.SetParamSimple(map, prefix + "AppPackage", this.AppPackage);
            this.SetParamSimple(map, prefix + "AppName", this.AppName);
            this.SetParamSimple(map, prefix + "AppVersion", this.AppVersion);
            this.SetParamSimple(map, prefix + "FileID", this.FileID);
            this.SetParamSimple(map, prefix + "AppDownloadUrl", this.AppDownloadUrl);
            this.SetParamSimple(map, prefix + "PrivacyTextUrl", this.PrivacyTextUrl);
            this.SetParamSimple(map, prefix + "ContactName", this.ContactName);
            this.SetParamSimple(map, prefix + "TelNumber", this.TelNumber);
            this.SetParamSimple(map, prefix + "Email", this.Email);
            this.SetParamSimple(map, prefix + "CorpName", this.CorpName);
            this.SetParamSimple(map, prefix + "SalesPerson", this.SalesPerson);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "IsAgreePrivacy", this.IsAgreePrivacy);
            this.SetParamSimple(map, prefix + "PrivacyTextName", this.PrivacyTextName);
        }
    }
}

