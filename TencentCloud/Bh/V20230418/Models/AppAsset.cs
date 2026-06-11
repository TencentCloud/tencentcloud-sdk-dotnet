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

    public class AppAsset : AbstractModel
    {
        
        /// <summary>
        /// <p>应用资产id</p>
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }

        /// <summary>
        /// <p>实例id</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>资产名称</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>应用服务器id</p>
        /// </summary>
        [JsonProperty("DeviceId")]
        public ulong? DeviceId{ get; set; }

        /// <summary>
        /// <p>应用服务器账号id</p>
        /// </summary>
        [JsonProperty("DeviceAccountId")]
        public ulong? DeviceAccountId{ get; set; }

        /// <summary>
        /// <p>应用资产类型。1-web应用</p>
        /// </summary>
        [JsonProperty("Kind")]
        public ulong? Kind{ get; set; }

        /// <summary>
        /// <p>客户端工具路径</p>
        /// </summary>
        [JsonProperty("ClientAppPath")]
        public string ClientAppPath{ get; set; }

        /// <summary>
        /// <p>客户端工具类型</p>
        /// </summary>
        [JsonProperty("ClientAppKind")]
        public string ClientAppKind{ get; set; }

        /// <summary>
        /// <p>应用资产url</p>
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// <p>托管状态</p><p>枚举值：</p><ul><li>0： 未托管</li><li>1： 已托管</li></ul>
        /// </summary>
        [JsonProperty("BindStatus")]
        public ulong? BindStatus{ get; set; }

        /// <summary>
        /// <p>应用服务器实例id</p>
        /// </summary>
        [JsonProperty("DeviceInstanceId")]
        public string DeviceInstanceId{ get; set; }

        /// <summary>
        /// <p>应用服务器名称</p>
        /// </summary>
        [JsonProperty("DeviceName")]
        public string DeviceName{ get; set; }

        /// <summary>
        /// <p>应用服务器账号名称</p>
        /// </summary>
        [JsonProperty("DeviceAccountName")]
        public string DeviceAccountName{ get; set; }

        /// <summary>
        /// <p>堡垒机实例id</p>
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// <p>堡垒机实例信息</p>
        /// </summary>
        [JsonProperty("Resource")]
        public Resource Resource{ get; set; }

        /// <summary>
        /// <p>网络域id</p>
        /// </summary>
        [JsonProperty("DomainId")]
        public string DomainId{ get; set; }

        /// <summary>
        /// <p>网络域名称</p>
        /// </summary>
        [JsonProperty("DomainName")]
        public string DomainName{ get; set; }

        /// <summary>
        /// <p>资产组信息</p>
        /// </summary>
        [JsonProperty("GroupSet")]
        public Group[] GroupSet{ get; set; }

        /// <summary>
        /// <p>资产所属部门</p>
        /// </summary>
        [JsonProperty("Department")]
        public Department Department{ get; set; }

        /// <summary>
        /// <p>账号数量</p>
        /// </summary>
        [JsonProperty("AccountCount")]
        public ulong? AccountCount{ get; set; }

        /// <summary>
        /// <p>代填类型</p><p>枚举值：</p><ul><li>0： 不支持代填</li><li>1： 元素定位代填</li></ul>
        /// </summary>
        [JsonProperty("AgentInputType")]
        public ulong? AgentInputType{ get; set; }

        /// <summary>
        /// <p>是否自动提交</p><p>枚举值：</p><ul><li>0： 不自动提交</li><li>1： 自动提交</li></ul>
        /// </summary>
        [JsonProperty("AgentInputSubmit")]
        public ulong? AgentInputSubmit{ get; set; }

        /// <summary>
        /// <p>用户名输入框选择器类型</p><p>枚举值：</p><ul><li>id： html标签id属性</li><li>name： html标签name属性</li><li>selector： css选择器</li><li>xpath： xpath</li></ul>
        /// </summary>
        [JsonProperty("UserNameType")]
        public string UserNameType{ get; set; }

        /// <summary>
        /// <p>用户名输入框选择器属性</p>
        /// </summary>
        [JsonProperty("UserNameValue")]
        public string UserNameValue{ get; set; }

        /// <summary>
        /// <p>密码输入框选择器类型</p><p>枚举值：</p><ul><li>id： html标签id属性</li><li>name： html标签name属性</li><li>selector： css选择器</li><li>xpath： xpath</li></ul>
        /// </summary>
        [JsonProperty("PasswordType")]
        public string PasswordType{ get; set; }

        /// <summary>
        /// <p>密码输入框选择器属性</p>
        /// </summary>
        [JsonProperty("PasswordValue")]
        public string PasswordValue{ get; set; }

        /// <summary>
        /// <p>提交按钮选择器类型，为空表示不支持自动提交</p><p>枚举值：</p><ul><li>id： html标签id属性</li><li>name： html标签name属性</li><li>selector： css选择器</li><li>xpath： xpath</li></ul>
        /// </summary>
        [JsonProperty("SubmitType")]
        public string SubmitType{ get; set; }

        /// <summary>
        /// <p>提交按钮选择器属性值</p>
        /// </summary>
        [JsonProperty("SubmitValue")]
        public string SubmitValue{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "DeviceId", this.DeviceId);
            this.SetParamSimple(map, prefix + "DeviceAccountId", this.DeviceAccountId);
            this.SetParamSimple(map, prefix + "Kind", this.Kind);
            this.SetParamSimple(map, prefix + "ClientAppPath", this.ClientAppPath);
            this.SetParamSimple(map, prefix + "ClientAppKind", this.ClientAppKind);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "BindStatus", this.BindStatus);
            this.SetParamSimple(map, prefix + "DeviceInstanceId", this.DeviceInstanceId);
            this.SetParamSimple(map, prefix + "DeviceName", this.DeviceName);
            this.SetParamSimple(map, prefix + "DeviceAccountName", this.DeviceAccountName);
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamObj(map, prefix + "Resource.", this.Resource);
            this.SetParamSimple(map, prefix + "DomainId", this.DomainId);
            this.SetParamSimple(map, prefix + "DomainName", this.DomainName);
            this.SetParamArrayObj(map, prefix + "GroupSet.", this.GroupSet);
            this.SetParamObj(map, prefix + "Department.", this.Department);
            this.SetParamSimple(map, prefix + "AccountCount", this.AccountCount);
            this.SetParamSimple(map, prefix + "AgentInputType", this.AgentInputType);
            this.SetParamSimple(map, prefix + "AgentInputSubmit", this.AgentInputSubmit);
            this.SetParamSimple(map, prefix + "UserNameType", this.UserNameType);
            this.SetParamSimple(map, prefix + "UserNameValue", this.UserNameValue);
            this.SetParamSimple(map, prefix + "PasswordType", this.PasswordType);
            this.SetParamSimple(map, prefix + "PasswordValue", this.PasswordValue);
            this.SetParamSimple(map, prefix + "SubmitType", this.SubmitType);
            this.SetParamSimple(map, prefix + "SubmitValue", this.SubmitValue);
        }
    }
}

