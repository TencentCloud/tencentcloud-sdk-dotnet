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

namespace TencentCloud.Dasb.V20191018.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyAclRequest : AbstractModel
    {
        
        /// <summary>
        /// 访问权限名称，最大32字符，不能包含空白字符
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 是否开启磁盘映射
        /// </summary>
        [JsonProperty("AllowDiskRedirect")]
        public bool? AllowDiskRedirect{ get; set; }

        /// <summary>
        /// 是否允许任意账号登录
        /// </summary>
        [JsonProperty("AllowAnyAccount")]
        public bool? AllowAnyAccount{ get; set; }

        /// <summary>
        /// 访问权限ID
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }

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
        /// 是否开启文件传输上传
        /// </summary>
        [JsonProperty("AllowFileUp")]
        public bool? AllowFileUp{ get; set; }

        /// <summary>
        /// 文件传输上传大小限制（预留参数，目前暂未使用）
        /// </summary>
        [JsonProperty("MaxFileUpSize")]
        public ulong? MaxFileUpSize{ get; set; }

        /// <summary>
        /// 是否开启文件传输下载
        /// </summary>
        [JsonProperty("AllowFileDown")]
        public bool? AllowFileDown{ get; set; }

        /// <summary>
        /// 文件传输下载大小限制（预留参数，目前暂未使用）
        /// </summary>
        [JsonProperty("MaxFileDownSize")]
        public ulong? MaxFileDownSize{ get; set; }

        /// <summary>
        /// 关联的用户ID
        /// </summary>
        [JsonProperty("UserIdSet")]
        public ulong?[] UserIdSet{ get; set; }

        /// <summary>
        /// 关联的用户组ID
        /// </summary>
        [JsonProperty("UserGroupIdSet")]
        public ulong?[] UserGroupIdSet{ get; set; }

        /// <summary>
        /// 关联的资产ID
        /// </summary>
        [JsonProperty("DeviceIdSet")]
        public ulong?[] DeviceIdSet{ get; set; }

        /// <summary>
        /// 关联的资产组ID
        /// </summary>
        [JsonProperty("DeviceGroupIdSet")]
        public ulong?[] DeviceGroupIdSet{ get; set; }

        /// <summary>
        /// 关联的账号
        /// </summary>
        [JsonProperty("AccountSet")]
        public string[] AccountSet{ get; set; }

        /// <summary>
        /// 关联的高危命令模板ID
        /// </summary>
        [JsonProperty("CmdTemplateIdSet")]
        public ulong?[] CmdTemplateIdSet{ get; set; }

        /// <summary>
        /// 是否开启 RDP 磁盘映射文件上传
        /// </summary>
        [JsonProperty("AllowDiskFileUp")]
        public bool? AllowDiskFileUp{ get; set; }

        /// <summary>
        /// 是否开启 RDP 磁盘映射文件下载
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
        /// 访问权限生效时间，如:"2021-09-22T00:00:00+00:00"
        /// 生效、失效时间不填则访问权限长期有效
        /// </summary>
        [JsonProperty("ValidateFrom")]
        public string ValidateFrom{ get; set; }

        /// <summary>
        /// 访问权限失效时间，如:"2021-09-23T00:00:00+00:00"
        /// 生效、失效时间不填则访问权限长期有效
        /// </summary>
        [JsonProperty("ValidateTo")]
        public string ValidateTo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "AllowDiskRedirect", this.AllowDiskRedirect);
            this.SetParamSimple(map, prefix + "AllowAnyAccount", this.AllowAnyAccount);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "AllowClipFileUp", this.AllowClipFileUp);
            this.SetParamSimple(map, prefix + "AllowClipFileDown", this.AllowClipFileDown);
            this.SetParamSimple(map, prefix + "AllowClipTextUp", this.AllowClipTextUp);
            this.SetParamSimple(map, prefix + "AllowClipTextDown", this.AllowClipTextDown);
            this.SetParamSimple(map, prefix + "AllowFileUp", this.AllowFileUp);
            this.SetParamSimple(map, prefix + "MaxFileUpSize", this.MaxFileUpSize);
            this.SetParamSimple(map, prefix + "AllowFileDown", this.AllowFileDown);
            this.SetParamSimple(map, prefix + "MaxFileDownSize", this.MaxFileDownSize);
            this.SetParamArraySimple(map, prefix + "UserIdSet.", this.UserIdSet);
            this.SetParamArraySimple(map, prefix + "UserGroupIdSet.", this.UserGroupIdSet);
            this.SetParamArraySimple(map, prefix + "DeviceIdSet.", this.DeviceIdSet);
            this.SetParamArraySimple(map, prefix + "DeviceGroupIdSet.", this.DeviceGroupIdSet);
            this.SetParamArraySimple(map, prefix + "AccountSet.", this.AccountSet);
            this.SetParamArraySimple(map, prefix + "CmdTemplateIdSet.", this.CmdTemplateIdSet);
            this.SetParamSimple(map, prefix + "AllowDiskFileUp", this.AllowDiskFileUp);
            this.SetParamSimple(map, prefix + "AllowDiskFileDown", this.AllowDiskFileDown);
            this.SetParamSimple(map, prefix + "AllowShellFileUp", this.AllowShellFileUp);
            this.SetParamSimple(map, prefix + "AllowShellFileDown", this.AllowShellFileDown);
            this.SetParamSimple(map, prefix + "AllowFileDel", this.AllowFileDel);
            this.SetParamSimple(map, prefix + "ValidateFrom", this.ValidateFrom);
            this.SetParamSimple(map, prefix + "ValidateTo", this.ValidateTo);
        }
    }
}

