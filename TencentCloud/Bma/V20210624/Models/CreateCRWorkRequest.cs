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

namespace TencentCloud.Bma.V20210624.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateCRWorkRequest : AbstractModel
    {
        
        /// <summary>
        /// 作品名称
        /// </summary>
        [JsonProperty("WorkName")]
        public string WorkName{ get; set; }

        /// <summary>
        /// 作品分类
        /// </summary>
        [JsonProperty("WorkCategory")]
        public string WorkCategory{ get; set; }

        /// <summary>
        /// 作品内容类型
        /// </summary>
        [JsonProperty("WorkType")]
        public string WorkType{ get; set; }

        /// <summary>
        /// 作品标签
        /// </summary>
        [JsonProperty("WorkSign")]
        public string WorkSign{ get; set; }

        /// <summary>
        /// 作品图片
        /// </summary>
        [JsonProperty("WorkPic")]
        public string WorkPic{ get; set; }

        /// <summary>
        /// 创作描述
        /// </summary>
        [JsonProperty("WorkDesc")]
        public string WorkDesc{ get; set; }

        /// <summary>
        /// 是否原创 0:否 1:是
        /// </summary>
        [JsonProperty("IsOriginal")]
        public string IsOriginal{ get; set; }

        /// <summary>
        /// 是否发布 0：未发布 1：已发布
        /// </summary>
        [JsonProperty("IsRelease")]
        public string IsRelease{ get; set; }

        /// <summary>
        /// 著作权人ID
        /// </summary>
        [JsonProperty("ProducerID")]
        public long? ProducerID{ get; set; }

        /// <summary>
        /// 创作时间
        /// </summary>
        [JsonProperty("ProduceTime")]
        public string ProduceTime{ get; set; }

        /// <summary>
        /// 样品文件路径
        /// </summary>
        [JsonProperty("SampleContentURL")]
        public string SampleContentURL{ get; set; }

        /// <summary>
        /// 样本下载Url
        /// </summary>
        [JsonProperty("SampleDownloadURL")]
        public string SampleDownloadURL{ get; set; }

        /// <summary>
        /// 授予类型
        /// </summary>
        [JsonProperty("GrantType")]
        public string GrantType{ get; set; }

        /// <summary>
        /// 作品发布Url
        /// </summary>
        [JsonProperty("SamplePublicURL")]
        public string SamplePublicURL{ get; set; }

        /// <summary>
        /// 是否启用监测 0：不启用 1：启用 默认为0
        /// </summary>
        [JsonProperty("IsMonitor")]
        public string IsMonitor{ get; set; }

        /// <summary>
        /// 是否启用存证0：不存证  2：存证 默认为0
        /// </summary>
        [JsonProperty("IsCert")]
        public string IsCert{ get; set; }

        /// <summary>
        /// 存证回调地址
        /// </summary>
        [JsonProperty("CertUrl")]
        public string CertUrl{ get; set; }

        /// <summary>
        /// 监测回调地址
        /// </summary>
        [JsonProperty("MonitorUrl")]
        public string MonitorUrl{ get; set; }

        /// <summary>
        /// 创作性质（原创,改编,翻译,汇编,注释,整理,其他)
        /// </summary>
        [JsonProperty("ProduceType")]
        public string ProduceType{ get; set; }

        /// <summary>
        /// 白名单
        /// </summary>
        [JsonProperty("WhiteLists")]
        public string[] WhiteLists{ get; set; }

        /// <summary>
        /// 作品ID
        /// </summary>
        [JsonProperty("WorkId")]
        public long? WorkId{ get; set; }

        /// <summary>
        /// 著作权人姓名
        /// </summary>
        [JsonProperty("ProducerName")]
        public string ProducerName{ get; set; }

        /// <summary>
        /// 作者
        /// </summary>
        [JsonProperty("Nickname")]
        public string Nickname{ get; set; }

        /// <summary>
        /// 授权书
        /// </summary>
        [JsonProperty("Authorization")]
        public string Authorization{ get; set; }

        /// <summary>
        /// 授权书开始时间
        /// </summary>
        [JsonProperty("AuthorizationStartTime")]
        public string AuthorizationStartTime{ get; set; }

        /// <summary>
        /// 授权书结束时间
        /// </summary>
        [JsonProperty("AuthorizationEndTime")]
        public string AuthorizationEndTime{ get; set; }

        /// <summary>
        /// 内容格式
        /// </summary>
        [JsonProperty("ContentType")]
        public string ContentType{ get; set; }

        /// <summary>
        /// 文件内容
        /// </summary>
        [JsonProperty("Content")]
        public string Content{ get; set; }

        /// <summary>
        /// 监测结束时间
        /// </summary>
        [JsonProperty("MonitorEndTime")]
        public string MonitorEndTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "WorkName", this.WorkName);
            this.SetParamSimple(map, prefix + "WorkCategory", this.WorkCategory);
            this.SetParamSimple(map, prefix + "WorkType", this.WorkType);
            this.SetParamSimple(map, prefix + "WorkSign", this.WorkSign);
            this.SetParamSimple(map, prefix + "WorkPic", this.WorkPic);
            this.SetParamSimple(map, prefix + "WorkDesc", this.WorkDesc);
            this.SetParamSimple(map, prefix + "IsOriginal", this.IsOriginal);
            this.SetParamSimple(map, prefix + "IsRelease", this.IsRelease);
            this.SetParamSimple(map, prefix + "ProducerID", this.ProducerID);
            this.SetParamSimple(map, prefix + "ProduceTime", this.ProduceTime);
            this.SetParamSimple(map, prefix + "SampleContentURL", this.SampleContentURL);
            this.SetParamSimple(map, prefix + "SampleDownloadURL", this.SampleDownloadURL);
            this.SetParamSimple(map, prefix + "GrantType", this.GrantType);
            this.SetParamSimple(map, prefix + "SamplePublicURL", this.SamplePublicURL);
            this.SetParamSimple(map, prefix + "IsMonitor", this.IsMonitor);
            this.SetParamSimple(map, prefix + "IsCert", this.IsCert);
            this.SetParamSimple(map, prefix + "CertUrl", this.CertUrl);
            this.SetParamSimple(map, prefix + "MonitorUrl", this.MonitorUrl);
            this.SetParamSimple(map, prefix + "ProduceType", this.ProduceType);
            this.SetParamArraySimple(map, prefix + "WhiteLists.", this.WhiteLists);
            this.SetParamSimple(map, prefix + "WorkId", this.WorkId);
            this.SetParamSimple(map, prefix + "ProducerName", this.ProducerName);
            this.SetParamSimple(map, prefix + "Nickname", this.Nickname);
            this.SetParamSimple(map, prefix + "Authorization", this.Authorization);
            this.SetParamSimple(map, prefix + "AuthorizationStartTime", this.AuthorizationStartTime);
            this.SetParamSimple(map, prefix + "AuthorizationEndTime", this.AuthorizationEndTime);
            this.SetParamSimple(map, prefix + "ContentType", this.ContentType);
            this.SetParamSimple(map, prefix + "Content", this.Content);
            this.SetParamSimple(map, prefix + "MonitorEndTime", this.MonitorEndTime);
        }
    }
}

