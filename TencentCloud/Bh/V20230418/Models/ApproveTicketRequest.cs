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

namespace TencentCloud.Bh.V20230418.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ApproveTicketRequest : AbstractModel
    {
        
        /// <summary>
        /// 工单唯一id，数据库索引id
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }

        /// <summary>
        /// 2-审批通过，4-审批驳回
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// 审批意见
        /// </summary>
        [JsonProperty("ApproveDesc")]
        public string ApproveDesc{ get; set; }

        /// <summary>
        /// 申请时间戳，单位微妙
        /// </summary>
        [JsonProperty("ApplyTimeVersion")]
        public long? ApplyTimeVersion{ get; set; }

        /// <summary>
        /// 审批权限工单时，设置的有效期开始时间，默认为当前时间
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 审批权限工单时，设置的有效期的结束时间，默认有限期为1天
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 是否开启磁盘映射
        /// </summary>
        [JsonProperty("AllowDiskRedirect")]
        public bool? AllowDiskRedirect{ get; set; }

        /// <summary>
        /// 是否开启剪贴板文件上行
        /// </summary>
        [JsonProperty("AllowClipFileUp")]
        public bool? AllowClipFileUp{ get; set; }

        /// <summary>
        /// 是否开启剪贴板文件下行
        /// </summary>
        [JsonProperty("AllowClipFileDown")]
        public bool? AllowClipFileDown{ get; set; }

        /// <summary>
        /// 是否开启剪贴板文本（含图片）上行
        /// </summary>
        [JsonProperty("AllowClipTextUp")]
        public bool? AllowClipTextUp{ get; set; }

        /// <summary>
        /// 是否开启剪贴板文本（含图片）下行
        /// </summary>
        [JsonProperty("AllowClipTextDown")]
        public bool? AllowClipTextDown{ get; set; }

        /// <summary>
        /// 是否开启 SFTP 文件上传
        /// </summary>
        [JsonProperty("AllowFileUp")]
        public bool? AllowFileUp{ get; set; }

        /// <summary>
        /// 文件传输上传大小限制（预留参数，目前暂未使用）
        /// </summary>
        [JsonProperty("MaxFileUpSize")]
        public ulong? MaxFileUpSize{ get; set; }

        /// <summary>
        /// 是否开启 SFTP 文件下载
        /// </summary>
        [JsonProperty("AllowFileDown")]
        public bool? AllowFileDown{ get; set; }

        /// <summary>
        /// 文件传输下载大小限制（预留参数，目前暂未使用）
        /// </summary>
        [JsonProperty("MaxFileDownSize")]
        public ulong? MaxFileDownSize{ get; set; }

        /// <summary>
        /// 是否开启rdp磁盘映射文件上传
        /// </summary>
        [JsonProperty("AllowDiskFileUp")]
        public bool? AllowDiskFileUp{ get; set; }

        /// <summary>
        /// 是否开启rdp磁盘映射文件下载
        /// </summary>
        [JsonProperty("AllowDiskFileDown")]
        public bool? AllowDiskFileDown{ get; set; }

        /// <summary>
        /// 是否开启rz sz文件上传
        /// </summary>
        [JsonProperty("AllowShellFileUp")]
        public bool? AllowShellFileUp{ get; set; }

        /// <summary>
        /// 是否开启rz sz文件下载
        /// </summary>
        [JsonProperty("AllowShellFileDown")]
        public bool? AllowShellFileDown{ get; set; }

        /// <summary>
        /// 是否开启 SFTP 文件删除
        /// </summary>
        [JsonProperty("AllowFileDel")]
        public bool? AllowFileDel{ get; set; }

        /// <summary>
        /// 是否允许使用访问串，默认允许
        /// </summary>
        [JsonProperty("AllowAccessCredential")]
        public bool? AllowAccessCredential{ get; set; }

        /// <summary>
        /// 关联的高危命令模板ID
        /// </summary>
        [JsonProperty("CmdTemplateIdSet")]
        public ulong?[] CmdTemplateIdSet{ get; set; }

        /// <summary>
        /// 关联高危DB模板ID
        /// </summary>
        [JsonProperty("ACTemplateIdSet")]
        public string[] ACTemplateIdSet{ get; set; }

        /// <summary>
        /// 部门id
        /// </summary>
        [JsonProperty("DepartmentId")]
        public string DepartmentId{ get; set; }

        /// <summary>
        /// 是否允许键盘记录
        /// </summary>
        [JsonProperty("AllowKeyboardLogger")]
        public bool? AllowKeyboardLogger{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ApproveDesc", this.ApproveDesc);
            this.SetParamSimple(map, prefix + "ApplyTimeVersion", this.ApplyTimeVersion);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "AllowDiskRedirect", this.AllowDiskRedirect);
            this.SetParamSimple(map, prefix + "AllowClipFileUp", this.AllowClipFileUp);
            this.SetParamSimple(map, prefix + "AllowClipFileDown", this.AllowClipFileDown);
            this.SetParamSimple(map, prefix + "AllowClipTextUp", this.AllowClipTextUp);
            this.SetParamSimple(map, prefix + "AllowClipTextDown", this.AllowClipTextDown);
            this.SetParamSimple(map, prefix + "AllowFileUp", this.AllowFileUp);
            this.SetParamSimple(map, prefix + "MaxFileUpSize", this.MaxFileUpSize);
            this.SetParamSimple(map, prefix + "AllowFileDown", this.AllowFileDown);
            this.SetParamSimple(map, prefix + "MaxFileDownSize", this.MaxFileDownSize);
            this.SetParamSimple(map, prefix + "AllowDiskFileUp", this.AllowDiskFileUp);
            this.SetParamSimple(map, prefix + "AllowDiskFileDown", this.AllowDiskFileDown);
            this.SetParamSimple(map, prefix + "AllowShellFileUp", this.AllowShellFileUp);
            this.SetParamSimple(map, prefix + "AllowShellFileDown", this.AllowShellFileDown);
            this.SetParamSimple(map, prefix + "AllowFileDel", this.AllowFileDel);
            this.SetParamSimple(map, prefix + "AllowAccessCredential", this.AllowAccessCredential);
            this.SetParamArraySimple(map, prefix + "CmdTemplateIdSet.", this.CmdTemplateIdSet);
            this.SetParamArraySimple(map, prefix + "ACTemplateIdSet.", this.ACTemplateIdSet);
            this.SetParamSimple(map, prefix + "DepartmentId", this.DepartmentId);
            this.SetParamSimple(map, prefix + "AllowKeyboardLogger", this.AllowKeyboardLogger);
        }
    }
}

