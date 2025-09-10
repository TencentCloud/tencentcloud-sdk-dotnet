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

namespace TencentCloud.Omics.V20221128.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RunApplicationRequest : AbstractModel
    {
        
        /// <summary>
        /// 应用ID。
        /// </summary>
        [JsonProperty("ApplicationId")]
        public string ApplicationId{ get; set; }

        /// <summary>
        /// 任务批次名称。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 投递环境ID。
        /// </summary>
        [JsonProperty("EnvironmentId")]
        public string EnvironmentId{ get; set; }

        /// <summary>
        /// 项目ID。（不填使用指定地域下的默认项目）
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 任务批次描述。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 任务输入COS地址。（InputBase64和InputCosUri必选其一）
        /// </summary>
        [JsonProperty("InputCosUri")]
        public string InputCosUri{ get; set; }

        /// <summary>
        /// 任务输入JSON。需要进行base64编码。（InputBase64和InputCosUri必选其一）
        /// </summary>
        [JsonProperty("InputBase64")]
        public string InputBase64{ get; set; }

        /// <summary>
        /// 批量投递表格ID，不填表示单例投递。
        /// </summary>
        [JsonProperty("TableId")]
        public string TableId{ get; set; }

        /// <summary>
        /// 批量投递表格行UUID。不填表示表格全部行。
        /// </summary>
        [JsonProperty("TableRowUuids")]
        public string[] TableRowUuids{ get; set; }

        /// <summary>
        /// 任务缓存清理时间（小时）。不填或0表示不清理。
        /// </summary>
        [JsonProperty("CacheClearDelay")]
        public ulong? CacheClearDelay{ get; set; }

        /// <summary>
        /// 应用版本ID。不填表示使用当前最新版本。
        /// </summary>
        [JsonProperty("ApplicationVersionId")]
        public string ApplicationVersionId{ get; set; }

        /// <summary>
        /// WDL运行选项。
        /// </summary>
        [JsonProperty("Option")]
        public RunOption Option{ get; set; }

        /// <summary>
        /// Nextflow运行选项。
        /// </summary>
        [JsonProperty("NFOption")]
        public NFOption NFOption{ get; set; }

        /// <summary>
        /// 工作目录，当前仅支持Nextflow。可填写指定缓存卷内的绝对路径或者COS路径，不填使用默认缓存卷内的默认路径。如果使用COS路径，NFOption中LaunchDir需填写指定缓存卷内的绝对路径作为启动路径。
        /// </summary>
        [JsonProperty("WorkDir")]
        public string WorkDir{ get; set; }

        /// <summary>
        /// 访问模式，不填默认私有。取值范围
        /// - PRIVATE：私有应用
        /// - PUBLIC：公共应用
        /// </summary>
        [JsonProperty("AccessMode")]
        public string AccessMode{ get; set; }

        /// <summary>
        /// 缓存卷ID，不填使用默认缓存卷，暂时仅支持Nextflow。
        /// </summary>
        [JsonProperty("VolumeIds")]
        public string[] VolumeIds{ get; set; }

        /// <summary>
        /// 是否开启结果通知。
        /// </summary>
        [JsonProperty("ResultNotification")]
        public bool? ResultNotification{ get; set; }

        /// <summary>
        /// 是否开启超时通知。
        /// </summary>
        [JsonProperty("TimeoutNotification")]
        public bool? TimeoutNotification{ get; set; }

        /// <summary>
        /// 任务超时通知时间（单位：分钟），支持5到2880分钟。
        /// </summary>
        [JsonProperty("TimeoutNotificationMinutes")]
        public ulong? TimeoutNotificationMinutes{ get; set; }

        /// <summary>
        /// 接受通知邮件地址列表。
        /// </summary>
        [JsonProperty("EmailForNotification")]
        public string[] EmailForNotification{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ApplicationId", this.ApplicationId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "EnvironmentId", this.EnvironmentId);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "InputCosUri", this.InputCosUri);
            this.SetParamSimple(map, prefix + "InputBase64", this.InputBase64);
            this.SetParamSimple(map, prefix + "TableId", this.TableId);
            this.SetParamArraySimple(map, prefix + "TableRowUuids.", this.TableRowUuids);
            this.SetParamSimple(map, prefix + "CacheClearDelay", this.CacheClearDelay);
            this.SetParamSimple(map, prefix + "ApplicationVersionId", this.ApplicationVersionId);
            this.SetParamObj(map, prefix + "Option.", this.Option);
            this.SetParamObj(map, prefix + "NFOption.", this.NFOption);
            this.SetParamSimple(map, prefix + "WorkDir", this.WorkDir);
            this.SetParamSimple(map, prefix + "AccessMode", this.AccessMode);
            this.SetParamArraySimple(map, prefix + "VolumeIds.", this.VolumeIds);
            this.SetParamSimple(map, prefix + "ResultNotification", this.ResultNotification);
            this.SetParamSimple(map, prefix + "TimeoutNotification", this.TimeoutNotification);
            this.SetParamSimple(map, prefix + "TimeoutNotificationMinutes", this.TimeoutNotificationMinutes);
            this.SetParamArraySimple(map, prefix + "EmailForNotification.", this.EmailForNotification);
        }
    }
}

