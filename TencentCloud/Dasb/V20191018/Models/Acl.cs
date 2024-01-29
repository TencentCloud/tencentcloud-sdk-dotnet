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

    public class Acl : AbstractModel
    {
        
        /// <summary>
        /// 访问权限ID
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }

        /// <summary>
        /// 访问权限名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

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
        /// 是否开启剪贴板文本（目前含图片）上行
        /// </summary>
        [JsonProperty("AllowClipTextUp")]
        public bool? AllowClipTextUp{ get; set; }

        /// <summary>
        /// 是否开启剪贴板文本（目前含图片）下行
        /// </summary>
        [JsonProperty("AllowClipTextDown")]
        public bool? AllowClipTextDown{ get; set; }

        /// <summary>
        /// 是否开启文件传输上传
        /// </summary>
        [JsonProperty("AllowFileUp")]
        public bool? AllowFileUp{ get; set; }

        /// <summary>
        /// 文件传输上传大小限制（预留参数，暂未启用）
        /// </summary>
        [JsonProperty("MaxFileUpSize")]
        public ulong? MaxFileUpSize{ get; set; }

        /// <summary>
        /// 是否开启文件传输下载
        /// </summary>
        [JsonProperty("AllowFileDown")]
        public bool? AllowFileDown{ get; set; }

        /// <summary>
        /// 文件传输下载大小限制（预留参数，暂未启用）
        /// </summary>
        [JsonProperty("MaxFileDownSize")]
        public ulong? MaxFileDownSize{ get; set; }

        /// <summary>
        /// 是否允许任意账号登录
        /// </summary>
        [JsonProperty("AllowAnyAccount")]
        public bool? AllowAnyAccount{ get; set; }

        /// <summary>
        /// 关联的用户列表
        /// </summary>
        [JsonProperty("UserSet")]
        public User[] UserSet{ get; set; }

        /// <summary>
        /// 关联的用户组列表
        /// </summary>
        [JsonProperty("UserGroupSet")]
        public Group[] UserGroupSet{ get; set; }

        /// <summary>
        /// 关联的资产列表
        /// </summary>
        [JsonProperty("DeviceSet")]
        public Device[] DeviceSet{ get; set; }

        /// <summary>
        /// 关联的资产组列表
        /// </summary>
        [JsonProperty("DeviceGroupSet")]
        public Group[] DeviceGroupSet{ get; set; }

        /// <summary>
        /// 关联的账号列表
        /// </summary>
        [JsonProperty("AccountSet")]
        public string[] AccountSet{ get; set; }

        /// <summary>
        /// 关联的高危命令模板列表
        /// </summary>
        [JsonProperty("CmdTemplateSet")]
        public CmdTemplate[] CmdTemplateSet{ get; set; }

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
        /// 是否开启 rz sz 文件上传
        /// </summary>
        [JsonProperty("AllowShellFileUp")]
        public bool? AllowShellFileUp{ get; set; }

        /// <summary>
        /// 是否开启 rz sz 文件下载
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
        /// 访问权限状态，1 - 已生效，2 - 未生效，3 - 已过期
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// 所属部门的信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Department")]
        public Department Department{ get; set; }

        /// <summary>
        /// 是否允许使用访问串，默认允许
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AllowAccessCredential")]
        public bool? AllowAccessCredential{ get; set; }

        /// <summary>
        /// 关联的数据库高危命令列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ACTemplateSet")]
        public ACTemplate[] ACTemplateSet{ get; set; }

        /// <summary>
        /// 关联的白命令命令
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WhiteCmds")]
        public string[] WhiteCmds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "AllowDiskRedirect", this.AllowDiskRedirect);
            this.SetParamSimple(map, prefix + "AllowClipFileUp", this.AllowClipFileUp);
            this.SetParamSimple(map, prefix + "AllowClipFileDown", this.AllowClipFileDown);
            this.SetParamSimple(map, prefix + "AllowClipTextUp", this.AllowClipTextUp);
            this.SetParamSimple(map, prefix + "AllowClipTextDown", this.AllowClipTextDown);
            this.SetParamSimple(map, prefix + "AllowFileUp", this.AllowFileUp);
            this.SetParamSimple(map, prefix + "MaxFileUpSize", this.MaxFileUpSize);
            this.SetParamSimple(map, prefix + "AllowFileDown", this.AllowFileDown);
            this.SetParamSimple(map, prefix + "MaxFileDownSize", this.MaxFileDownSize);
            this.SetParamSimple(map, prefix + "AllowAnyAccount", this.AllowAnyAccount);
            this.SetParamArrayObj(map, prefix + "UserSet.", this.UserSet);
            this.SetParamArrayObj(map, prefix + "UserGroupSet.", this.UserGroupSet);
            this.SetParamArrayObj(map, prefix + "DeviceSet.", this.DeviceSet);
            this.SetParamArrayObj(map, prefix + "DeviceGroupSet.", this.DeviceGroupSet);
            this.SetParamArraySimple(map, prefix + "AccountSet.", this.AccountSet);
            this.SetParamArrayObj(map, prefix + "CmdTemplateSet.", this.CmdTemplateSet);
            this.SetParamSimple(map, prefix + "AllowDiskFileUp", this.AllowDiskFileUp);
            this.SetParamSimple(map, prefix + "AllowDiskFileDown", this.AllowDiskFileDown);
            this.SetParamSimple(map, prefix + "AllowShellFileUp", this.AllowShellFileUp);
            this.SetParamSimple(map, prefix + "AllowShellFileDown", this.AllowShellFileDown);
            this.SetParamSimple(map, prefix + "AllowFileDel", this.AllowFileDel);
            this.SetParamSimple(map, prefix + "ValidateFrom", this.ValidateFrom);
            this.SetParamSimple(map, prefix + "ValidateTo", this.ValidateTo);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamObj(map, prefix + "Department.", this.Department);
            this.SetParamSimple(map, prefix + "AllowAccessCredential", this.AllowAccessCredential);
            this.SetParamArrayObj(map, prefix + "ACTemplateSet.", this.ACTemplateSet);
            this.SetParamArraySimple(map, prefix + "WhiteCmds.", this.WhiteCmds);
        }
    }
}

